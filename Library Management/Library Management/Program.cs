using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string libr = "|DataDirectory|\\Library.mdf"; 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         //  Application.Run(new user_ui(2001,libr));
           // Application.Run(new book(20002,2005,"بهنام آزین",true));
            Application.Run(new Form1());
        //   Application.Run(new admin(0,0,libr));
        }
    }
}
