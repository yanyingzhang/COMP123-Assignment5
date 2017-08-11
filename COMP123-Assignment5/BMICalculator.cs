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
 * Version: 0.2 - Added the radioButton_Clicked()
 */
namespace COMP123_Assignment5
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLE
        private bool _imperialClicked;

        // PUBLIC PROPERTIES
        public bool ImperialClicked
        {
            get
            {
                return this._imperialClicked;
            }
            set
            {
                this._imperialClicked = value;
            }
        }

        // CONSTRUCTORS
        public BMICalculator()
        {
            InitializeComponent();
        }
        
        // PRIVATE METHODS

        // PUBLIC METHODS

            /// <summary>
            /// This is the method to choose the unit
            /// If "Imperial" is chosen, the unit will be "inch" and "pound"
            /// If not, the unit will be "cm" and "kg"
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void radioButton_Clicked(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (this.ImperialRadio.Checked)
            {
                this.HeightUnitLabel.Text = "inch";
                this.WeightUnitLabel.Text = "pound";
            }
            else
            {
                this.HeightUnitLabel.Text = "m";
                this.WeightUnitLabel.Text = "kg";
            }
        }

     
    }
}
