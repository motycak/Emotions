using Emotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier", "Dragonfly");
            Application.Run(new MainForm());
        }
    }
}
