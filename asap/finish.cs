using System;
using System.Windows.Forms;

namespace asap
{
    public partial class finish : Form
    {
        public finish(menu Menu, string language, int scenario, string susp)
        {
            InitializeComponent();
            MenuWindow = Menu;
            lang = language;

            scenario_number = scenario;
            suspected_illness = susp;
    }

        private void scoreCount()
        {

        }

        private void finish_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer1.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
