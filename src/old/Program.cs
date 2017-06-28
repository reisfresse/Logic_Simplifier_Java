using System;
using System.Windows.Forms;

namespace LogicSimplifier
{
    internal static class Program
    {
        public static MainForm Mf;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mf = new MainForm();
            Application.Run(Mf);
            //EasterEgg ee = new EasterEgg();
            //ee.unzip();
            //ee.createProcess(true);
        }
    }
}