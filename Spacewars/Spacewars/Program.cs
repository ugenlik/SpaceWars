using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Spacewars
{
    static class Program
    {
		public static Random random = new Random();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}