﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Yanying Zhang - 300926213
 * Date: Aug.11 2017
 * Description: Assignment5
 * Version: 0.5 - Added _convertInput method
 */
namespace COMP123_Assignment5
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLE
        private double _bmi;

        private string _result;

        private double _userHeight;

        private double _userWeight;

        // PUBLIC PROPERTIES

        public double BMI
        {
            get
            {
                return this._bmi;
            }
            set
            {
                this._bmi = value;
            }
        }

        public string Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public double UserHeight
        {
            get
            {
                return this._userHeight;
            }
            set
            {
                this._userHeight = value;
            }
        }
        public double UserWeight
        {
            get
            {
                return this._userWeight;
            }
            set
            {
                this._userWeight = value;
            }
        }

        // CONSTRUCTORS
        public BMICalculator()
        {
            InitializeComponent();
        }
        
        // PRIVATE METHODS

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
                this.HeightUnitLabel.Text = "meter";
                this.WeightUnitLabel.Text = "kg";
            }
        }

        /// <summary>
        /// This is the method calculate the BMI and show the string of BMI result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            UserHeight = _convertInput(HeightInputTextBox.Text);
            UserWeight = _convertInput((WeightInputTextBox.Text));
            
            if (this.ImperialRadio.Checked)
            {
                BMI = Math.Round(((UserWeight * 703) / (UserHeight * UserHeight)), 1);
            }
            else
            {
                BMI = Math.Round((UserWeight / (UserHeight * UserHeight)), 1);
            }

            if (BMI < 18.5)
            {
                Result = "Underweight";
            }
            if (BMI >= 18.5 && BMI <= 24.9)
            {
                Result = "Normal";
            }
            if (BMI >= 25 && BMI <= 29.9)
            {
                Result = "Overweight";
            }
            if (BMI >= 30)
            {
                Result = "Obse";
            }

            this.BMITextBox.Text = BMI.ToString();
            this.BMITextBox.Text = Convert.ToString(BMI);
            this.BMIResultTextBox.Text = Result;
        }

       private double _convertInput(string inputString)
        {
            try
            {
                return Convert.ToDouble(inputString);
            }
            catch(Exception e)
            {
                Debug.WriteLine("An Error Occurred");
                Debug.WriteLine(e.Message);
            }
            return 0;
        }

        /// <summary>
        /// This method is to clear all the value entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.BMITextBox.Text = "";
            this.BMIResultTextBox.Text = "";
            this.WeightInputTextBox.Text = "";
            this.HeightInputTextBox.Text = "";
        }

        // PUBLIC METHODS
    }
}
