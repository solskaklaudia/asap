using System;
using System.Windows.Forms;

namespace asap
{
    public partial class education : Form
    {
        public education()
        {
            InitializeComponent();
        }

        public education(menu Menu, string language)
        {
            InitializeComponent();
            MenuWindow = Menu;
            lang = language;

            if (lang == "eng")
            {
                IllnessLabel.Text = "Illness 1";
                IllnessDescription.Text = "Illness description 1";

                button1.Text = "Illness 1";
                button2.Text = "Illness 2";
                button3.Text = "Illness 3";         
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            button_clicked = btn.Name;

            if(lang == "pl")
            {
                switch (button_clicked)
                {
                    case "button1":
                        IllnessLabel.Text = "Choroba 1";
                        IllnessDescription.Text = "Opis choroby 1";
                        break;

                    case "button2":
                        IllnessLabel.Text = "Choroba 2";
                        IllnessDescription.Text = "Opis choroby 2";
                        break;

                    case "button3":
                        IllnessLabel.Text = "Choroba 3";
                        IllnessDescription.Text = "Opis choroby 3";
                        break;

                    default:
                        break;
                }
            }
            else if(lang == "eng")
            {
                switch (button_clicked)
                {
                    case "button1":
                        IllnessLabel.Text = "Illness 1";
                        IllnessDescription.Text = "Illness description 1";
                        break;

                    case "button2":
                        IllnessLabel.Text = "Illness 2";
                        IllnessDescription.Text = "Illness description 2";
                        break;

                    case "button3":
                        IllnessLabel.Text = "Illness 3";
                        IllnessDescription.Text = "Illness description 3";
                        break;

                    default:
                        break;
                }
            }
        }

        private void education_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer1.Enabled = true;
        }
    }
}
