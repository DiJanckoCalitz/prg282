using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// by Brett wilson 601081 Di-jancko_calitz 600356 joshua levi visser 601085

// Github link for this repositorie: https://github.com/DiJanckoCalitz/prg282

namespace project282
{
    // please see FileManager.cs, Students.cs, Gui.cs

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
            Application.Run(new Gui());
        }
    }
}
