﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Yanying Zhang - 300926213
 * Date: Aug.3 2017
 * Description: Assignment5
 * Version: 0.1 - Created the project
 */
namespace COMP123_Assignment5
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
            Application.Run(new BMICalculator());
        }
    }
}
