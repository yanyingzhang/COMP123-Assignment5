using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Yanying Zhang - 300926213
 * Date: Aug.11 2017
 * Description: Assignment5
 * Version: 0.2 - Added splashTimer_Tick method
 */
namespace COMP123_Assignment5
{
    public partial class SplashScreen : Form
    {
        // public properties
        public BMICalculator BMIcalculator
        {
            get
            {
                return Program.BMIcalculator;
            }
        }

        // constructors
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler for SplashScreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            this.BMIcalculator.Show();
            this.Hide();
            splashTimer.Enabled = false;
        }
    }
}
