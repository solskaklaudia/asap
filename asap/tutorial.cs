using System;
using System.Drawing;
using System.Windows.Forms;

namespace asap
{
    public partial class tutorial : Form
    {
        public tutorial()
        {
            InitializeComponent();
        }

        public tutorial(menu Menu, string language)
        {
            InitializeComponent();
            MenuWindow = Menu;
            lang = language;

            file_path = "..\\..\\graphics\\tutorial\\" + lang + "\\";
            this.BackgroundImage = Image.FromFile(file_path + tutorial_count.ToString() + ".png");

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

        private void tutorialButtonExit_Click(object sender, EventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer1.Enabled = true;
            this.Close();
        }

        private void tutorialButtonNext_Click(object sender, EventArgs e)
        {
            // loads next tutorial image and enables/disables needed buttons
            tutorial_count++;

            if (tutorial_count == 1)
            {
                tutorialButtonPrevious.Visible = tutorialButtonPrevious.Enabled = false;
                tutorialButtonNext.Visible = tutorialButtonNext.Enabled = true;
            }
            else if (tutorial_count == 2)
            {
                tutorialButtonPrevious.Visible = tutorialButtonPrevious.Enabled = true;
            }
            else if (tutorial_count >= 3)
            {
                tutorialButtonNext.Visible = tutorialButtonNext.Enabled = false;
            }

            string file_path = "..\\..\\graphics\\tutorial\\" + lang + "\\";
            this.BackgroundImage = Image.FromFile(file_path + tutorial_count.ToString() + ".png");
        }

        private void tutorialButtonPrevious_Click(object sender, EventArgs e)
        {
            // loads previous tutorial image and enables/disables needed buttons
            tutorial_count--;

            if (tutorial_count <= 1)
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

            file_path = "..\\..\\graphics\\tutorial\\" + lang + "\\";
            this.BackgroundImage = Image.FromFile(file_path + tutorial_count.ToString() + ".png");
        }

        private void tutorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer1.Enabled = true;
        }
    }
}
