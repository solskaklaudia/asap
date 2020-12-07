using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace asap
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        public game(menu Menu, string language)
        {
            InitializeComponent();
            MenuWindow = Menu;
            lang = language;

            generateScenario();

            if(lang == "pl")
            {
                susIllnessLabel.Text = "Podejrzewane schorzenie:";
            }
            else if(lang == "eng")
            {
                susIllnessLabel.Text = "Suspected illness:";
            }

            maxtime = 10; // this will be read from scenario file later

            // displaying randomly generated scenario number, this label will be removed later
            label1.Text = "Numer scenariusza: " + scenario_number.ToString();
        }

        public void generateScenario()
        {
            try
            {
                // generating random scenario
                Random rnd = new Random();
                scenario_number = rnd.Next(1, number_of_scenarios + 1);

                string txt_file_path = "..\\..\\txtres\\" + lang + "\\";
                string cursor_file_path = "..\\..\\graphics\\game\\hud\\cursor.ico";

                // reading symptoms and illnesses from files
                string[] ill_lines = File.ReadAllLines(txt_file_path + "illnesses.txt");
                string[] sym_lines = File.ReadAllLines(txt_file_path + "symptoms.txt");

                // reading custom cursor from file
                curs = new Cursor(cursor_file_path);

                foreach (string line in ill_lines)
                {
                    illnesses.Add(line); // adding illnesses to list
                    suspectedIllnessList.Items.Add(line); // generating menu items in list with illnesses
                }

                foreach (string line in sym_lines)
                {
                    symptoms.Add(line); // adding symptoms to list
                    symptomsComboBox.Items.Add(line); // generating toolstip menu items with symptoms
                }

                // ComboBox with symptoms events and properties
                symptomsComboBox.SelectedIndexChanged += new System.EventHandler(this.addSuspectedSymptom); ;
                symptomsComboBox.Font = new Font("Arial", 12, FontStyle.Bold);
                symptomsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                // List with illnesses events and properties
                suspectedIllnessList.SelectedIndexChanged += new System.EventHandler(this.illnessSelected); ;
                suspectedIllnessList.Font = new Font("Arial", 12, FontStyle.Bold);

                ///
                /// there will be code for generating dialogue objects for chosen scenario based on text file
                ///
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gameFinish()
        {
            string message = "";

            if (called)
            {
                message = "Dzwonisz po pogotowie.";
                if (illnesses[scenario_number - 1] == suspected_illness)
                {
                    message += " Zgadłeś chorobę " + suspected_illness + " w scenariuszu nr " + scenario_number.ToString();
                }
                else
                {
                    message += " Nie zgadłeś choroby.";
                }
            }
            else
            {
                message = "Nie zadzwoniłeś w porę po pomoc, przegrywasz.";
            }
            
            MessageBox.Show(message);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void game_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer1.Enabled = true;
        }    

        private void addSuspectedSymptom(object sender, EventArgs e) 
        {
            string symptom = (sender as ToolStripComboBox).Text;

            if (!suspected_symptoms.Contains(symptom))
            {
                suspected_symptoms.Add(symptom);

                suspectedSymptom sus = new suspectedSymptom(symptom);
                symptomPanel.Controls.Add(sus.button);
                symptomPanel.Controls.Add(sus.label);
                sus.button.Click += delegate { 
                    sus.button.Dispose(); 
                    sus.label.Dispose();
                    suspected_symptoms.Remove(symptom);
                    if (suspected_symptoms.Count == 0)
                    {
                        susIllnessLabel.Visible = susIllnessLabel.Enabled = false;
                        suspectedIllnessList.Visible = suspectedIllnessList.Enabled = false;
                    }
                };
            }

            if (suspected_symptoms.Count > 0)
            {
                susIllnessLabel.Visible = susIllnessLabel.Enabled = true;
                suspectedIllnessList.Visible = suspectedIllnessList.Enabled = true;
            }

            symptomsContextMenu.Hide();
            this.Cursor = Cursors.Default;
            lens.BackgroundImage = asap.Properties.Resources.lens;
        }

        private void illnessSelected(object sender, EventArgs e)
        {
            string illness = (sender as ComboBox).Text;
            suspected_illness = illness;  
        }

        private void game_MouseClick(object sender, MouseEventArgs e)
        {
            if (Cursor == curs)
            {
                symptomsContextMenu.Show(this, Cursor.Position);
            }
        }

        private void lens_Click(object sender, EventArgs e)
        {
            if(Cursor == Cursors.Hand)
            {
                this.Cursor = curs;
                lens.BackgroundImage = asap.Properties.Resources.lens_empty;
            }
            else
            {
                this.Cursor = Cursors.Hand;
                lens.BackgroundImage = asap.Properties.Resources.lens;
            } 
        }

        private void dialogue_Click(object sender, EventArgs e)
        {
            // changing phone time with every round by 1 minute
            if(time[1] == 59)
            {
                time[1] = 0;
                if (time[0] == 23)
                {
                    time[0] = 0;
                }
                else
                {
                    time[0]++;
                }
            }
            else
            {
                time[1]++;
            }

            time_label.Text = time[0].ToString("D2") + ":" + time[1].ToString("D2");

            // ending the game is max scenario time is reached
            time_counter++;
            if(maxtime == time_counter)
            {
                gameFinish();
            }
        }

        private void lens_MouseEnter(object sender, EventArgs e)
        {
            lens.Width = lens.Height = (int)(lens.Width * 0.9);
            if(Cursor == Cursors.Default)
            {
                Cursor = Cursors.Hand;
            }
        }

        private void lens_MouseLeave(object sender, EventArgs e)
        {
            lens.Width = lens.Height = 280;
            if (Cursor == Cursors.Hand)
            {
                Cursor = Cursors.Default;
            }
        }

        private void phone_Click(object sender, EventArgs e)
        {
            called = true;
            gameFinish();
        }

        private void phone_MouseEnter(object sender, EventArgs e)
        {
            phone.Width = (int)(phone.Width * 0.98);
            phone.Height = (int)(phone.Height * 0.98);
        }

        private void phone_MouseLeave(object sender, EventArgs e)
        {
            phone.Width = 250;
            phone.Height = 460;
        }
    }
}
