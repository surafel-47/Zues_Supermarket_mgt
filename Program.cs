using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopMgtSys;
using WindowsFormsApp1;
using WindowsFormsApp1.AdminClass;

namespace ShopMgtSys
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
            Application.Run(new AdminMainMenu());
           // Application.Run(new MakeTransaction(3));
            //Application.Run(new MakeTransaction());
        }
    }
}
