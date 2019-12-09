using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backbone;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //SQLDatabase.InsertIntoDatabase.InsertIntoNotification("TEST MESSAGE", "adminuser", "adminuser");
            SQLDatabase.SelectFromDatabase.LoadDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new LogOnForm());
        }
    }
}
