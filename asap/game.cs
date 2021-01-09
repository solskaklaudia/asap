using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Partial class <c>game</c> extending Form for game section of the program
    /// </summary>
    public partial class game : Form
    {
        /// <summary>
        /// <c>game</c> form window constructor
        /// </summary>
        public game(menu Menu, string language)
        {
            InitializeComponent();
            
            // setting variable values
            MenuWindow = Menu;
            lang = language;

            try
            {
                music = new SoundPlayer("..\\..\\res\\music\\Envision.wav"); // reads music file
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (MenuWindow.musicPlaying) // if the music setting is on
            {
                music.PlayLooping();
            }

            generateScenario();

            // setting suspected illness label text depending on the language
            if(lang == "pl")
            {
                susIllnessLabel.Text = "Podejrzewane schorzenie:";
            }
            else if(lang == "eng")
            {
                susIllnessLabel.Text = "Suspected illness:";
            }
        }

        /// <summary>
        /// Method <c>generateScenario</c> generates random scenario number, random background and reads illnesses, symptoms and dialogue options from text files
        /// </summary>
        public void generateScenario()
        {
            try
            {
                // generating random scenario number
                Random rnd = new Random();
                scenario_number = rnd.Next(0, scenarios.Length);

                // generating random clock time
                time[0] = rnd.Next(11, 15);
                time[1] = rnd.Next(0, 59);
                time_label.Text = time[0].ToString("D2") + ":" + time[1].ToString("D2"); // displaying time on phone label

                // strings containing resources file paths
                string txt_file_path = "..\\..\\res\\txtres\\" + lang + "\\";
                string scnlen_file_path = "..\\..\\res\\txtres\\";
                string cursor_file_path = "..\\..\\res\\graphics\\game\\hud\\cursor.ico";
                string bg_file_path = "..\\..\\res\\graphics\\game\\bg\\";

                // reading max scenario length from file
                maxtime = Int32.Parse(File.ReadAllText(scnlen_file_path + scenarios[scenario_number] + "_scnlen.txt"));

                // reading random background image for the scenario
                int bg_number = 0;
                if(scenarios[scenario_number] == "hs") // if scenario is a heat stroke
                {
                    bg_number = rnd.Next(0, 2); // backgrounds outside
                }
                else if (scenarios[scenario_number] == "st") // if scenario is a stroke
                {
                    bg_number = rnd.Next(3, 5); // backgrounds inside
                }
                else
                {
                    bg_number = rnd.Next(0, 5); // random background
                }
                this.BackgroundImage = Image.FromFile(bg_file_path + bg_number + ".jpg");

                // reading symptoms and illnesses from files to arrays
                string[] ill_lines = File.ReadAllLines(txt_file_path + "illnesses.txt");
                string[] sym_lines = File.ReadAllLines(txt_file_path + "symptoms.txt");

                // sorting the symptom array alphabetically
                Array.Sort(sym_lines);

                // reading custom cursor from file
                curs = new Cursor(cursor_file_path);

                foreach (string line in ill_lines)
                {
                    illnesses.Add(line); // adding illnesses to list
                    suspectedIllnessList.Items.Add(line); // generating menu items in list with illnesses
                }

                foreach (string line in sym_lines)
                {
                    if (!symptoms.Contains(line)) // if symptom isn't already in the List collection
                    {
                        symptoms.Add(line); // adding symptoms to list
                        symptomsComboBox.Items.Add(line); // generating toolstip menu items with symptoms
                    }         
                }

                // ComboBox with symptoms events and properties
                symptomsComboBox.SelectedIndexChanged += new System.EventHandler(this.addSuspectedSymptom); ;
                symptomsComboBox.Font = new Font("Arial", 12, FontStyle.Bold);
                symptomsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                symptomsComboBox.DropDownWidth = 420;

                // List with illnesses events and properties
                suspectedIllnessList.SelectedIndexChanged += new System.EventHandler(this.illnessSelected); ;
                suspectedIllnessList.Font = new Font("Arial", 12, FontStyle.Bold);

                //generating dialogue objects for chosen scenario based on text file
                dialogueOption.generateDialogues(lang, scenarios[scenario_number]);
                dialogueOption.nextDialogue(0, this, scenarios[scenario_number]); // sets the first dialogue options of the scenario
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method <c>addSuspectedSymptom</c> adds suspected symptom by the user to the notepad
        /// </summary>
        private void addSuspectedSymptom(object sender, EventArgs e) 
        {
            string symptom = (sender as ToolStripComboBox).Text; // reads string from chosen ToolStripComboBox option

            if (suspected_symptoms.Count >=10) // if the notepad is full
            {
                string message;

                // displays the message based on the language
                if(lang == "pl")
                {
                    message = "Nie ma już miejsca w notatniku! Usuń któryś objaw, aby dodać kolejny.";
                    MessageBox.Show(message);
                }
                else if(lang == "eng")
                {
                    message = "No free notepad space! Delete some symptom to add a new one." ;
                    MessageBox.Show(message);
                }  
            }
            else if (!suspected_symptoms.Contains(symptom)) // if the symptom isn't on the notepad already
            {
                suspected_symptoms.Add(symptom); // adds suspected symptom to the List collection

                // creates new suspectedSymptom object and adds its button and label to the notepad panel
                suspectedSymptom sus = new suspectedSymptom(symptom);
                symptomPanel.Controls.Add(sus.button);
                symptomPanel.Controls.Add(sus.label);

                // sets mouse click event function using delegate
                sus.button.Click += delegate { 
                    sus.button.Dispose(); 
                    sus.label.Dispose();
                    suspected_symptoms.Remove(symptom);
                    if (suspected_symptoms.Count == 0) // if there are no suspected symptoms on the notepad
                    {
                        // hiding the suspected illness combobox
                        susIllnessLabel.Visible = susIllnessLabel.Enabled = false;
                        suspectedIllnessList.Visible = suspectedIllnessList.Enabled = false;
                    }
                };
            }

            // shows the suspected illness combobox if there are any suspected symptoms on the notepad
            if (suspected_symptoms.Count > 0)
            {
                susIllnessLabel.Visible = susIllnessLabel.Enabled = true;
                suspectedIllnessList.Visible = suspectedIllnessList.Enabled = true;
            }

            symptomsContextMenu.Hide(); // hides the symptoms context menu
            this.Cursor = Cursors.Default; // changes cursor back to default
            lens.Image = asap.Properties.Resources.lens; // changes the lens image to full
        }

        /// <summary>
        /// Method <c>illnessSelected</c> sets suspected illness value chosen by the user
        /// </summary>
        private void illnessSelected(object sender, EventArgs e)
        {
            string illness = (sender as ComboBox).Text;
            suspected_illness = illness;  
        }

        /// <summary>
        /// Method <c>game_MouseClick</c> shows context menu with symptoms if cursor is a lens cursor
        /// </summary>
        private void game_MouseClick(object sender, MouseEventArgs e)
        {
            if (Cursor == curs)
            {
                symptomsContextMenu.Show(this, Cursor.Position);
            }
        }

        /// <summary>
        /// Method <c>dialogue_Click</c> when dialogue option is clicked - invokes nextDialogue method of dialogueOption class, changes phone time, ends game if reached max scenario time
        /// </summary>
        private void dialogue_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int number = Int32.Parse(button.AccessibleDescription); // getting the dialoge option number from the button parameter
            
            dialogueOption.nextDialogue(number, this, scenarios[scenario_number]); // next dialogue options and character reaction
            
            // changing phone display time with every round by 1 minute
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

            // ending the game if max scenario time is reached
            time_counter++;
            if(maxtime == time_counter)
            {
                gameFinish();
            }
        }

        /// <summary>
        /// Method <c>lens_Click</c> changes lens image to full/empty depending on current cursor
        /// </summary>
        private void lens_Click(object sender, EventArgs e)
        {
            if (Cursor == Cursors.Hand)
            {
                this.Cursor = curs;
                lens.Image = asap.Properties.Resources.lens_empty;
            }
            else
            {
                this.Cursor = Cursors.Hand;
                lens.Image = asap.Properties.Resources.lens;
            }
        }

        /// <summary>
        /// Method <c>lens_MouseEnter</c> changes the lens size and cursor type on mouse enter
        /// </summary>
        private void lens_MouseEnter(object sender, EventArgs e)
        {           
            if (Cursor == Cursors.Default)
            {
                Cursor = Cursors.Hand;
            }
            if (Cursor == curs)
            {
                lens.Image = asap.Properties.Resources.lens_empty_small;
            }
            else
            {
                lens.Image = asap.Properties.Resources.lens_small;
            }
        }

        /// <summary>
        /// Method <c>lens_MouseLeave</c> changes the lens size and cursor type on mouse leave
        /// </summary>
        private void lens_MouseLeave(object sender, EventArgs e)
        {          
            if (Cursor == Cursors.Hand)
            {
                Cursor = Cursors.Default;
            }
            if (Cursor == curs)
            {
                lens.Image = asap.Properties.Resources.lens_empty;
            }
            else
            {
                lens.Image = asap.Properties.Resources.lens;
            }
        }

        /// <summary>
        /// Method <c>phone_Click</c> asks the user if they want to end the game; if yes - sets the "called" variable to true and ends the game
        /// </summary>
        private void phone_Click(object sender, EventArgs e)
        {
            string content = "";
            string title = "";

            // sets message title and content depending on the language
            if(lang == "pl")
            {
                title = "Telefon";
                content = "Czy na pewno chcesz zadzwonić po pogotowie i zakończyć grę?";
            }
            else if (lang == "eng")
            {
                title = "Phone";
                content = "Are you sure you want to call the ambulance and end the game?";
            }
      
            DialogResult dialogResult = MessageBox.Show(content, title, MessageBoxButtons.YesNo); // displays messagebox with yes and no buttons

            if (dialogResult == DialogResult.Yes) // if yes, finish the game
            {
                called = true;
                gameFinish();
            }          
        }

        /// <summary>
        /// Method <c>phone_MouseEnter</c> changes the phone size and cursor type on mouse enter
        /// </summary>
        private void phone_MouseEnter(object sender, EventArgs e)
        {
            phone.Image = asap.Properties.Resources.phone_small;
            time_label.Font = new Font("Microsoft Sans Serif", (int)(33 * 0.98));
            if (Cursor == Cursors.Default)
            {
                Cursor = Cursors.Hand;
            }
        }

        /// <summary>
        /// Method <c>phone_MouseLeave</c> changes the phone size and cursor type on mouse leave
        /// </summary>
        private void phone_MouseLeave(object sender, EventArgs e)
        {
            phone.Image = asap.Properties.Resources.phone;
            time_label.Font = new Font("Microsoft Sans Serif", 35);
            if (Cursor == Cursors.Hand)
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Method <c>dialogue_MouseEnter</c> changes dialogue background image on mouse enter
        /// </summary>
        private void dialogue_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = asap.Properties.Resources.sp_hover;
        }

        /// <summary>
        /// Method <c>dialogue_MouseLeave</c> changes dialogue background image on mouse leave
        /// </summary>
        private void dialogue_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = asap.Properties.Resources.sp;
        }

        /// <summary>
        /// Method <c>gameFinish</c> opens the finish window then game ends and closes game window
        /// </summary>
        private void gameFinish()
        {
            FinishWindow = new finish(this, MenuWindow, lang, scenario_number, suspected_illness, called, illnesses, suspected_symptoms);
            FinishWindow.Show();
            if (MenuWindow.musicPlaying) // if the music setting is on
            {
                music.Stop();
                MenuWindow.music.PlayLooping();
            }
            this.Close();
        }

        /// <summary>
        /// Method <c>buttonExit_Click</c> closes the form upon clicking the button if "yes" selected, enables menu window and its music and timer
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            string content = "";
            string title = "";

            // sets message title and content depending on the language
            if (lang == "pl")
            {
                content = "Czy na pewno chcesz zamknąć grę i wrócić do głównego menu?";
            }
            else if (lang == "eng")
            {
                content = "Are you sure you want to close the game and go back to the main menu?";
            }

            DialogResult dialogResult = MessageBox.Show(content, title, MessageBoxButtons.YesNo); // displays messagebox with yes and no buttons

            if (dialogResult == DialogResult.Yes) // if yes, close the game
            {
                MenuWindow.Visible = MenuWindow.Enabled = true;
                MenuWindow.timer.Enabled = true;
                if (MenuWindow.musicPlaying) // if the music setting is on
                {
                    music.Stop();
                    MenuWindow.music.PlayLooping();
                }
                this.Close();
            }
        }
    }
}
