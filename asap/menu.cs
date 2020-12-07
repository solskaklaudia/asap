using System;
using System.Drawing;
using System.Windows.Forms;

namespace asap
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // animated menu background
                if (tile_counter > 38)
                {
                    tile_counter = 1;
                }

                //AppDomain.CurrentDomain.BaseDirectory 

                string bg_file_path = "..\\..\\graphics\\menu\\background_tile\\" + tile_counter.ToString("D4") + ".png";      
                this.BackgroundImage = Image.FromFile(bg_file_path);
                tile_counter++;
            }
            catch(Exception ex)
            {
                this.timer1.Enabled = false;
                MessageBox.Show(ex.ToString());
            }
        }

        private void menubutton_MouseEnter(object sender, EventArgs e)
        {
            // changing button size and cursor on mouse enter
            PictureBox menubutton = (PictureBox)sender;

            menubutton_width = menubutton.Size.Width;
            menubutton_height = menubutton.Size.Height;

            double scale = 0.97;
            menubutton.Size = new Size((int)(menubutton_width * scale), (int)(menubutton_height * scale));

            this.Cursor = Cursors.Hand;
        }

        private void menubutton_MouseLeave(object sender, EventArgs e)
        {
            // changing back the button size and cursor on leave
            PictureBox menubutton = (PictureBox)sender;

            menubutton.Size = new Size(menubutton_width, menubutton_height);

            this.Cursor = Cursors.Default;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // opens new game window, hides and disables menu window
            this.GameWindow = new game(this, lang);
            GameWindow.Show();
            timer1.Enabled = false;
            this.Visible = this.Enabled = false;
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            // opens new tutorial window, hides and disables menu window
            this.TutWindow = new tutorial(this, lang);
            TutWindow.Show();
            timer1.Enabled = false;
            this.Visible = this.Enabled = false;
        }

        private void educationButton_Click(object sender, EventArgs e)
        {
            // opens new education window, hides and disables menu window
            this.EduWindow = new education(this, lang);
            EduWindow.Show();
            timer1.Enabled = false;
            this.Visible = this.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // closes the application
            this.Close();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            // showing the credits; disabling menu buttons and radio buttons
            radioLang1.Visible = radioLang1.Enabled = true;
            radioLang2.Visible = radioLang2.Enabled = true;
            buttonClose.Visible = buttonClose.Enabled = true;
            TextBox.Visible = true;
            playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = false;
            radioLang1.Visible = radioLang1.Enabled = false;
            radioLang2.Visible = radioLang2.Enabled = false;

            // shows game credits info
            if (lang == "pl")
            {
                TextBox.Text = "\n\tGra ASAP - As Soon As Possible została stworzona przez Klaudię Solską na potrzeby projektu z przedmiotu \"Współczesne Języki Programowania\".";
            }
            else if (lang == "eng")
            {
                TextBox.Text = "\n\tASAP - As Soon As Possible was created by Klaudia Solska for a \"Modern Programming Languages\" project.";
            }
        }

        private void gear_Click(object sender, EventArgs e)
        {
            // language selection
            if (lang == "pl")
            {
                TextBox.Text = "\n\tJęzyk gry:";
                radioLang1.Checked = true;
                radioLang2.Checked = false;
            }
            else if (lang == "eng")
            {
                TextBox.Text = "\n\tLanguage:";
                radioLang1.Checked = false;
                radioLang2.Checked = true;
            }

            // showing the settings and radio buttons; disabling menu buttons 
            radioLang1.Visible = radioLang1.Enabled = true;
            radioLang2.Visible = radioLang2.Enabled = true;
            buttonClose.Visible = buttonClose.Enabled = true;
            TextBox.Visible = true;
            playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = false;
        }

        private void radioLang_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // changing language setting
                if (radioLang1.Checked)
                {
                    lang = "pl";
                }
                else if (radioLang2.Checked)
                {
                    lang = "eng";
                }

                // disabling setting objects
                radioLang1.Visible = radioLang1.Enabled = false;
                radioLang2.Visible = radioLang2.Enabled = false;
                TextBox.Visible = false;
                playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = true;
                buttonClose.Visible = buttonClose.Enabled = false;

                // changing menu objects
                string file_path = "..\\..\\graphics\\menu\\" + lang + "\\";
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // disabling settings / credits items and enabling menu buttons
            radioLang1.Visible = radioLang1.Enabled = false;
            radioLang2.Visible = radioLang2.Enabled = false;
            TextBox.Visible = false;
            playButton.Enabled = tutorialButton.Enabled = educationButton.Enabled = exitButton.Enabled = true;
            buttonClose.Visible = buttonClose.Enabled = false;
        }
    }
}
