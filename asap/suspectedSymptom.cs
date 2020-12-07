using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asap
{
    public class suspectedSymptom // notepad suspected symptoms class
    {
        public Button button = new Button();
        public Label label = new Label();

        public suspectedSymptom(string name)
        {
            button.Text = "X";
            button.Width = 30;
            label.Text = name;
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.Margin = new Padding(5);
            label.Width = 177;
        }
    }
}
