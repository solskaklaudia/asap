using System;
using System.IO;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Partial class <c>education</c> extending Form for education section of the game
    /// </summary>
    public partial class education : Form
    {
        /// <summary>
        /// Constructor <c>education</c> reads the text files and generates titles and descriptions
        /// </summary>
        /// <param name="Menu"></param> menu window form.
        /// <param name="language"></param> informs about the text language.
        public education(menu Menu, string language)
        {
            InitializeComponent();

            MenuWindow = Menu;
            lang = language;

            string txt_file_path = "..\\..\\res\\txtres\\" + lang + "\\"; // relative path to all the text files

            try
            {
                foreach (string ill in game.scenarios)
                {
                    string[] illn = File.ReadAllLines(txt_file_path + ill + ".txt"); // reading illnesses descriptions
                    illnesses.Add(illn); // addind illnesses descriptions to collection
                    string[] symp = File.ReadAllLines(txt_file_path + ill + "_symptoms.txt"); // reading illnesses symptoms
                    illnesses_symptoms.Add(symp); // addind illnesses symptoms to collection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            // adding text (illness names) to buttons
            button1.Text = illnesses[0][0];
            button2.Text = illnesses[1][0];
            button3.Text = illnesses[2][0];

            generateText(0);
        }

        /// <summary>
        /// Method <c>generateText</c> displays info about a chosen illness.
        /// </summary>
        /// <param name="number"></param>
         private void generateText(int number)
        {
            // clears the description and symptoms text
            IllnessDescription.Text = "";
            PossibleSymptoms.Text = "";

            for (int i = 0; i < illnesses[number].Length; i++)
            {
                if (i == 0) // first line of text file contains illness name
                {
                    IllnessLabel.Text = illnesses[number][i]; // changes illness title text
                }
                else
                {
                    IllnessDescription.Text += illnesses[number][i] + "\n"; // adds description text lines
                }
            }

            // Displays text depending on a chosen language
            if (lang == "pl")
            {
                PossibleSymptoms.Text = "Możliwe objawy: \n\n";
            }
            else if (lang == "eng")
            {
                PossibleSymptoms.Text = "Possible symptoms: \n\n";
            }

            for (int i = 0; i < illnesses_symptoms[number].Length; i++)
            {
                PossibleSymptoms.Text += "- " + illnesses_symptoms[number][i] + "\n"; // adds symptoms text lines
            }
        }

        /// <summary>
        /// Method <c>button_Click</c> calls the generateText method for a chosen illness upon clicking the button.
        /// </summary>
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int button_number = Int32.Parse(btn.AccessibleDescription); // reads the button number from description and converts it to int32
            generateText(button_number); // displays chosen illness info
        }

        /// <summary>
        /// Method <c>buttonExit_Click</c> closes the form upon clicking the button.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method <c>education_FormClosing</c> enables menu window and its timer upon closing the education window.
        /// </summary>
        private void education_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer.Enabled = true;
        }
    }
}
