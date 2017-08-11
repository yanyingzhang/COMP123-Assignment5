namespace COMP123_Assignment5
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadio = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightInputTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightInputTextBox = new System.Windows.Forms.TextBox();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadio = new System.Windows.Forms.RadioButton();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightInputTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightInputTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.AutoSize = true;
            this.ImperialRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadio.Location = new System.Drawing.Point(21, 12);
            this.ImperialRadio.Name = "ImperialRadio";
            this.ImperialRadio.Size = new System.Drawing.Size(185, 50);
            this.ImperialRadio.TabIndex = 0;
            this.ImperialRadio.TabStop = true;
            this.ImperialRadio.Text = "Imperial";
            this.ImperialRadio.UseVisualStyleBackColor = true;
            this.ImperialRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(98, 64);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height";
            // 
            // HeightInputTextBox
            // 
            this.HeightInputTextBox.Location = new System.Drawing.Point(121, 3);
            this.HeightInputTextBox.Name = "HeightInputTextBox";
            this.HeightInputTextBox.Size = new System.Drawing.Size(100, 53);
            this.HeightInputTextBox.TabIndex = 2;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 74);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(104, 64);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            // 
            // WeightInputTextBox
            // 
            this.WeightInputTextBox.Location = new System.Drawing.Point(121, 77);
            this.WeightInputTextBox.Name = "WeightInputTextBox";
            this.WeightInputTextBox.Size = new System.Drawing.Size(100, 53);
            this.WeightInputTextBox.TabIndex = 4;
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BMITextBox.Location = new System.Drawing.Point(151, 250);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(118, 53);
            this.BMITextBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(21, 250);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(97, 53);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Location = new System.Drawing.Point(21, 331);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(248, 63);
            this.BMIResultTextBox.TabIndex = 7;
            // 
            // MetricRadio
            // 
            this.MetricRadio.AutoSize = true;
            this.MetricRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadio.Location = new System.Drawing.Point(155, 12);
            this.MetricRadio.Name = "MetricRadio";
            this.MetricRadio.Size = new System.Drawing.Size(154, 50);
            this.MetricRadio.TabIndex = 8;
            this.MetricRadio.TabStop = true;
            this.MetricRadio.Text = "Metric";
            this.MetricRadio.UseVisualStyleBackColor = true;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(239, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(0, 46);
            this.HeightUnitLabel.TabIndex = 5;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(239, 74);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(0, 46);
            this.WeightUnitLabel.TabIndex = 6;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.MetricRadio);
            this.Controls.Add(this.BMIResultTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.ImperialRadio);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadio;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightInputTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightInputTextBox;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.RadioButton MetricRadio;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
    }
}

