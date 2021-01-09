using System;
using System.Drawing;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Partial class <c>tutorial</c> extending Form for tutorial section of the game
    /// </summary>
    public partial class tutorial : Form
    {
        /// <summary>
        /// <c>tutorial</c> constructor, sets the buttons text and loads background image
        /// </summary>
        public tutorial(menu Menu, string language)
        {
            InitializeComponent();

            MenuWindow = Menu;
            lang = language;

            file_path = "..\\..\\res\\graphics\\tutorial\\" + lang + "\\"; // sets file path for graphics resources
            this.BackgroundImage = Image.FromFile(file_path + tutorial_count.ToString() + ".jpg"); // loads tutorial background image

            // sets buttons text depending on the language
            if (lang == "pl")
            {
                tutorialButtonNext.Text = "Dalej";
                tutorialButtonPrevious.Text = "Wcześniej";
            }
            else if (lang == "eng")
            {
                tutorialButtonNext.Text = "Next";
                tutorialButtonPrevious.Text = "Previous";
            }
        }

        /// <summary>
        /// Method <c>tutorialButtonNext_Click</c> for next tutorial page functionality
        /// </summary>
        private void tutorialButtonNext_Click(object sender, EventArgs e)
        {
            tutorial_count++; // increasing tutorial page count

            setButtonsAndImage();
        }

        /// <summary>
        /// Method <c>tutorialButtonPrevious_Click</c> for previous tutorial page functionality
        /// </summary>
        private void tutorialButtonPrevious_Click(object sender, EventArgs e)
        {
            tutorial_count--; // decreasing tutorial page count

            setButtonsAndImage();
        }

        /// <summary>
        /// Method <c>setButtonsAndImage</c> loads tutorial image and enables/disables needed buttons
        /// </summary>
        private void setButtonsAndImage()
        {
            // enabled/disabled buttons depending on tutorial page number
            if (tutorial_count == 1)
            {
                tutorialButtonPrevious.Visible = tutorialButtonPrevious.Enabled = false;
                tutorialButtonNext.Visible = tutorialButtonNext.Enabled = true;
            }
            else if (tutorial_count == 2)
            {
                tutorialButtonPrevious.Visible = tutorialButtonPrevious.Enabled = true;
            }
            else if (tutorial_count == 3)
            {
                tutorialButtonNext.Visible = tutorialButtonNext.Enabled = false;
            }
            
            this.BackgroundImage = Image.FromFile(file_path + tutorial_count.ToString() + ".jpg"); // loads tutorial background image
        }

        /// <summary>
        /// Method <c>buttonExit_Click</c> closes the form upon clicking the button.
        /// </summary>
        private void tutorialButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method <c>tutorial_FormClosing</c> enables menu window and its timer upon closing the tutorial window.
        /// </summary>
        private void tutorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer.Enabled = true;
        }
    }
}
