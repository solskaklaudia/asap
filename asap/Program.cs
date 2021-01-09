using System;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Main program class
    /// </summary>
    static class Program
    {
        /// <summary></summary>
        /// <value></value>
        static menu menu
        {
            get => default;
            set{}
        }

        /// <summary>
        /// Main entrance point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());
        }
    }
}
