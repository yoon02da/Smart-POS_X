using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Smart_POS_X.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Smart_POS_X
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Receipt());
        }
    }
}
