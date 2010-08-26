using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace TwitterGambler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TODO: Had to add error handling here because of web request errors not being caught properly
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (TargetInvocationException tiex)
            {
                MessageBox.Show("Twitter says you're over the limit. Ugh.");
            }
            catch (Exception ex)
            { 
            
            }
        }
    }
}
