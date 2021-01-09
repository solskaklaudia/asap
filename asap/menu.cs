using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Partial class <c>menu</c> extending Form for main menu window of the game
    /// </summary>
    public partial class menu : Form
    {
        /// <summary>
        /// <c>menu</c> constructor
        /// </summary>
        public menu()
        {
            InitializeComponent();

            try
            {
                music = new SoundPlayer("..\\..\\res\\music\\Beauty Flow.wav"); // reads music file
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // plays the background music on loop
            music.PlayLooping();
        }

        /// <summary>
        /// Method <c>timer1_Tick</c> loads new background animation frame every tick
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // resets tile counter
                if (tile_counter > 38)
                {
                    tile_counter = 1;
                }

                string bg_file_path = "..\\..\\res\\graphics\\menu\\background_tile\\" + tile_counter.ToString("D4") + ".png"; // string with path to animation frame image
                this.BackgroundImage = Image.FromFile(bg_file_path); // loads the background image
                tile_counter++; // increases animation frame tile counter
            }
            catch(Exception ex)
            {
                this.timer.Enabled = false;
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method <c>menubutton_MouseEnter</c> for changing button size and cursor on mouse enter
        /// </summary>
        private void menubutton_MouseEnter(object sender, EventArgs e)
        {
            PictureBox menubutton = (PictureBox)sender;

            // saving current menu button size parameters to variable
            menubutton_width = menubutton.Size.Width;
            menubutton_height = menubutton.Size.Height;

            double scale = 0.97; // menu button scaling factor
            menubutton.Size = new Size((int)(menubutton_width * scale), (int)(menubutton_height * scale)); // changing menu button size

            this.Cursor = Cursors.Hand; // changing cursor to hand
        }

        /// <summary>
        /// Method <c>menubutton_MouseLeave</c> for changing back the button size and cursor on leave
        /// </summary>
        private void menubutton_MouseLeave(object sender, EventArgs e)
        {
            PictureBox menubutton = (PictureBox)sender;

            menubutton.Size = new Size(menubutton_width, menubutton_height); // restoring original menu button size

            this.Cursor = Cursors.Default; // changing cursor to default
        }

        /// <summary>
        /// Method <c>playButton_Click</c> stops menu music, opens new game window, hides and disables menu window
        /// </summary>
        private void playButton_Click(object sender, EventArgs e)
        {
            music.Stop();
            this.GameWindow = new game(this, lang);
            GameWindow.Show();
            timer.Enabled = false;
            this.Visible = this.Enabled = false;
        }

        /// <summary>
        /// Method <c>tutorialButton_Click</c> opens new tutorial window, hides and disables menu window
        /// </summary>
        private void tutorialButton_Click(object sender, EventArgs e)
        {
            this.TutWindow = new tutorial(this, lang);
            TutWindow.Show();
            timer.Enabled = false;
            this.Visible = this.Enabled = false;
        }

        /// <summary>
        /// Method <c>educationButton_Click</c> opens new education window, hides and disables menu window
        /// </summary>
        private void educationButton_Click(object sender, EventArgs e)
        {
            this.EduWindow = new education(this, lang);
            EduWindow.Show();
            timer.Enabled = false;
            this.Visible = this.Enabled = false;
        }

        /// <summary>
        /// Method <c>credits_Click</c> shows game credits info and disables menu buttons
        /// </summary>
        private void credits_Click(object sender, EventArgs e)
        {
            // showing the credits; disabling menu buttons and radio buttons
            settingsPanel.Visible = settingsPanel.Enabled = true;
            buttonClose.Visible = buttonClose.Enabled = true;
            TextBox.Visible = true;
            playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = false;
            settingsPanel.Visible = settingsPanel.Enabled = false;

            // sets game credits info
            if (lang == "pl")
            {
                TextBox.Text = "\n\tGra ASAP - As Soon As Possible została stworzona przez Klaudię Solską na potrzeby projektu z przedmiotu \"Współczesne Języki Programowania\"."
                    + "\n\n\tWszystkie zasoby gry są albo własnego autorstwa, albo z Internetu udostępnione na licencjach do darmowego użytku."
                    + "\n\n\tMuzyka w wykonaniu Kevin MacLeod (incompetech.com) na licencji Creative Commons.";
            }
            else if (lang == "eng")
            {
                TextBox.Text = "\n\tASAP - As Soon As Possible was created by Klaudia Solska for a \"Modern Programming Languages\" project."
                    + "\n\n\tAll the game resources are either self-made or downloaded from the Internet with free use license."
                    + "\n\n\tMusic made by Kevin MacLeod (incompetech.com). Licensed under Creative Commons.";
            }
        }

        /// <summary>
        /// Method <c>gear_Click</c> shows game settings and disables menu buttons
        /// </summary>
        private void gear_Click(object sender, EventArgs e)
        {
            // language selection, changes displayed text and radiobutton selection
            if (lang == "pl")
            {
                TextBox.Text = "\n\tJęzyk gry:";
                musicLabel.Text = "Muzyka:";
                radioLang1.Checked = true;
                radioLang2.Checked = false;
            }
            else if (lang == "eng")
            {
                TextBox.Text = "\n\tLanguage:";
                musicLabel.Text = "Music:";
                radioLang1.Checked = false;
                radioLang2.Checked = true;
            }

            // showing the settings and radio buttons; disabling menu buttons 
            settingsPanel.Visible = settingsPanel.Enabled = true;
            buttonClose.Visible = buttonClose.Enabled = true;
            TextBox.Visible = true;
            playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = false;
        }

        /// <summary>
        /// Method <c>radioLang_CheckedChanged</c> sets the chosen language when setting changed
        /// </summary>
        private void radioLang_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // changing language variable value
                if (radioLang1.Checked)
                {
                    lang = "pl";
                }
                else if (radioLang2.Checked)
                {
                    lang = "eng";
                }

                // disabling and hiding settings objects
                settingsPanel.Visible = settingsPanel.Enabled = false;
                TextBox.Visible = false;
                playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = true;
                buttonClose.Visible = buttonClose.Enabled = false;

                // setting a new file path and loading menu buttons for a chosen language
                string file_path = "..\\..\\res\\graphics\\menu\\" + lang + "\\";
                this.playButton.BackgroundImage = Image.FromFile(file_path + "play.png");
                this.tutorialButton.BackgroundImage = Image.FromFile(file_path + "tutorial.png");
                this.educationButton.BackgroundImage = Image.FromFile(file_path + "education.png");
                this.exitButton.BackgroundImage = Image.FromFile(file_path + "exit.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        /// <summary>
        /// Method <c>musicControl_CheckedChanged</c> turns the music on or off
        /// </summary>
        private void musicControl_CheckedChanged(object sender, EventArgs e)
        {
            // turning the music on / off
            if (musicControl.Checked)
            {
                music.PlayLooping();
                musicPlaying = true;
            }
            else
            {
                music.Stop();
                musicPlaying = false;
            }
        }

        /// <summary>
        /// Method <c>buttonClose_Click</c> for disabling settings / credits items and enabling menu buttons
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = settingsPanel.Enabled = false;
            TextBox.Visible = false;
            playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = true;
            buttonClose.Visible = buttonClose.Enabled = false;
        }

        /// <summary>
        /// Method <c>exitButton_Click</c> closes the application
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
