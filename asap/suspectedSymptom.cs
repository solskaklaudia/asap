using System.Drawing;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Class <c>suspectedSymptom</c> for notepad suspected symptoms objects
    /// </summary>
    public class suspectedSymptom
    {
        /// <summary>Button with X for deleting suspected symptoms from the notepad</summary>
        public Button button = new Button();
        /// <summary>Label with symptom name on the notepad</summary>
        public Label label = new Label();

        /// <summary>
        /// Constructor <c>suspectedSymptom</c> for suspectedSymptom object class
        /// </summary>
        /// <param name="name"></param> variable with suspected symptom name
        public suspectedSymptom(string name)
        {
            // setting button parameters
            button.Text = "X";
            button.Width = 30;

            // setting label parameters
            label.Text = name;
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.Margin = new Padding(5);
            label.Width = 223;
        }
    }
}
