using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
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

            // Initialize the Sql connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DataBaseType.Sql);
            // Application.Run(new tournamentDashBoardForm());
            Application.Run(new CreatePrizeForm()); 
        }
    }
}
