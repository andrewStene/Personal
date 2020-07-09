namespace Plate_Calculator
{
    partial class Form1
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
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.barWeight = new System.Windows.Forms.TextBox();
            this.totalWeight = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.totalWeightLabel = new System.Windows.Forms.Label();
            this.barWeightLabel = new System.Windows.Forms.Label();
            this.jackedMeterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 121);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(311, 158);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // barWeight
            // 
            this.barWeight.Location = new System.Drawing.Point(223, 42);
            this.barWeight.Name = "barWeight";
            this.barWeight.Size = new System.Drawing.Size(100, 20);
            this.barWeight.TabIndex = 1;
            // 
            // totalWeight
            // 
            this.totalWeight.Location = new System.Drawing.Point(12, 42);
            this.totalWeight.Name = "totalWeight";
            this.totalWeight.Size = new System.Drawing.Size(100, 20);
            this.totalWeight.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(248, 293);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Get Jacked";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // totalWeightLabel
            // 
            this.totalWeightLabel.AutoSize = true;
            this.totalWeightLabel.Location = new System.Drawing.Point(12, 26);
            this.totalWeightLabel.Name = "totalWeightLabel";
            this.totalWeightLabel.Size = new System.Drawing.Size(68, 13);
            this.totalWeightLabel.TabIndex = 4;
            this.totalWeightLabel.Text = "Total Weight";
            // 
            // barWeightLabel
            // 
            this.barWeightLabel.AutoSize = true;
            this.barWeightLabel.Location = new System.Drawing.Point(220, 26);
            this.barWeightLabel.Name = "barWeightLabel";
            this.barWeightLabel.Size = new System.Drawing.Size(60, 13);
            this.barWeightLabel.TabIndex = 5;
            this.barWeightLabel.Text = "Bar Weight";
            // 
            // jackedMeterLabel
            // 
            this.jackedMeterLabel.AutoSize = true;
            this.jackedMeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jackedMeterLabel.Location = new System.Drawing.Point(12, 98);
            this.jackedMeterLabel.Name = "jackedMeterLabel";
            this.jackedMeterLabel.Size = new System.Drawing.Size(149, 20);
            this.jackedMeterLabel.TabIndex = 6;
            this.jackedMeterLabel.Text = "JACKED METER:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 328);
            this.Controls.Add(this.jackedMeterLabel);
            this.Controls.Add(this.barWeightLabel);
            this.Controls.Add(this.totalWeightLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalWeight);
            this.Controls.Add(this.barWeight);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Jacked and Tan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.TextBox barWeight;
        private System.Windows.Forms.TextBox totalWeight;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label totalWeightLabel;
        private System.Windows.Forms.Label barWeightLabel;
        private System.Windows.Forms.Label jackedMeterLabel;
    }
}

