using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Yanying Zhang - 300926213
 * Date: Aug.3 2017
 * Description: Assignment5
 * Version: 0.2 - Created the new instance
 */
namespace COMP123_Assignment5
{
    static class Program
    {
        // create references for the form
        public static BMICalculator BMIcalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BMIcalculator = new BMICalculator();

            Application.Run(new SplashScreen());
        }
    }
}
