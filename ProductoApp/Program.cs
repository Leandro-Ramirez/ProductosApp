#region Usos
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using ProductoApp.Formularios;
using System.Collections.Generic;
#endregion

namespace ProductoApp
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
            Application.Run(new Form1());
        }
    }
}
