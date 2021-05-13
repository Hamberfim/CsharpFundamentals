
namespace dryWeightConversion
{
    partial class DryWeightConversion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCupsToGrams = new System.Windows.Forms.Label();
            this.lblGramsToCups = new System.Windows.Forms.Label();
            this.lblTitleDryWeightConversion = new System.Windows.Forms.Label();
            this.txtGramsInput = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtCupsInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCupsToGramsOutput = new System.Windows.Forms.TextBox();
            this.txtGramsToCupsOutput = new System.Windows.Forms.TextBox();
            this.lblRounded = new System.Windows.Forms.Label();
            this.txtGramsToCupsRoundedOutput = new System.Windows.Forms.TextBox();
            this.lblGrams = new System.Windows.Forms.Label();
            this.lblCups = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateCupsToGrams = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnCalculateGramsToCups = new System.Windows.Forms.Button();
            this.lblHR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCupsToGrams
            // 
            this.lblCupsToGrams.AutoSize = true;
            this.lblCupsToGrams.Location = new System.Drawing.Point(25, 174);
            this.lblCupsToGrams.Name = "lblCupsToGrams";
            this.lblCupsToGrams.Size = new System.Drawing.Size(78, 15);
            this.lblCupsToGrams.TabIndex = 0;
            this.lblCupsToGrams.Text = "Input Grams: ";
            // 
            // lblGramsToCups
            // 
            this.lblGramsToCups.AutoSize = true;
            this.lblGramsToCups.Location = new System.Drawing.Point(32, 67);
            this.lblGramsToCups.Name = "lblGramsToCups";
            this.lblGramsToCups.Size = new System.Drawing.Size(71, 15);
            this.lblGramsToCups.TabIndex = 1;
            this.lblGramsToCups.Text = "Input Cups: ";
            // 
            // lblTitleDryWeightConversion
            // 
            this.lblTitleDryWeightConversion.AutoSize = true;
            this.lblTitleDryWeightConversion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTitleDryWeightConversion.Location = new System.Drawing.Point(28, 7);
            this.lblTitleDryWeightConversion.Name = "lblTitleDryWeightConversion";
            this.lblTitleDryWeightConversion.Size = new System.Drawing.Size(205, 22);
            this.lblTitleDryWeightConversion.TabIndex = 2;
            this.lblTitleDryWeightConversion.Text = "Dry Weight Conversion";
            // 
            // txtGramsInput
            // 
            this.txtGramsInput.Location = new System.Drawing.Point(105, 64);
            this.txtGramsInput.Name = "txtGramsInput";
            this.txtGramsInput.Size = new System.Drawing.Size(100, 23);
            this.txtGramsInput.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(29, 97);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(74, 15);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "converted = ";
            // 
            // txtCupsInput
            // 
            this.txtCupsInput.Location = new System.Drawing.Point(105, 170);
            this.txtCupsInput.Name = "txtCupsInput";
            this.txtCupsInput.Size = new System.Drawing.Size(100, 23);
            this.txtCupsInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "converted = ";
            // 
            // txtCupsToGramsOutput
            // 
            this.txtCupsToGramsOutput.Location = new System.Drawing.Point(105, 93);
            this.txtCupsToGramsOutput.Name = "txtCupsToGramsOutput";
            this.txtCupsToGramsOutput.ReadOnly = true;
            this.txtCupsToGramsOutput.Size = new System.Drawing.Size(100, 23);
            this.txtCupsToGramsOutput.TabIndex = 7;
            // 
            // txtGramsToCupsOutput
            // 
            this.txtGramsToCupsOutput.Location = new System.Drawing.Point(105, 200);
            this.txtGramsToCupsOutput.Name = "txtGramsToCupsOutput";
            this.txtGramsToCupsOutput.ReadOnly = true;
            this.txtGramsToCupsOutput.Size = new System.Drawing.Size(100, 23);
            this.txtGramsToCupsOutput.TabIndex = 8;
            // 
            // lblRounded
            // 
            this.lblRounded.AutoSize = true;
            this.lblRounded.Location = new System.Drawing.Point(207, 255);
            this.lblRounded.Name = "lblRounded";
            this.lblRounded.Size = new System.Drawing.Size(35, 15);
            this.lblRounded.TabIndex = 9;
            this.lblRounded.Text = "cups.";
            // 
            // txtGramsToCupsRoundedOutput
            // 
            this.txtGramsToCupsRoundedOutput.Location = new System.Drawing.Point(105, 251);
            this.txtGramsToCupsRoundedOutput.Name = "txtGramsToCupsRoundedOutput";
            this.txtGramsToCupsRoundedOutput.ReadOnly = true;
            this.txtGramsToCupsRoundedOutput.Size = new System.Drawing.Size(100, 23);
            this.txtGramsToCupsRoundedOutput.TabIndex = 10;
            // 
            // lblGrams
            // 
            this.lblGrams.AutoSize = true;
            this.lblGrams.Location = new System.Drawing.Point(207, 97);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(43, 15);
            this.lblGrams.TabIndex = 11;
            this.lblGrams.Text = "grams.";
            // 
            // lblCups
            // 
            this.lblCups.AutoSize = true;
            this.lblCups.Location = new System.Drawing.Point(207, 204);
            this.lblCups.Name = "lblCups";
            this.lblCups.Size = new System.Drawing.Size(35, 15);
            this.lblCups.TabIndex = 12;
            this.lblCups.Text = "cups.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rounded to nearest quarter = ";
            // 
            // btnCalculateCupsToGrams
            // 
            this.btnCalculateCupsToGrams.Location = new System.Drawing.Point(105, 282);
            this.btnCalculateCupsToGrams.Name = "btnCalculateCupsToGrams";
            this.btnCalculateCupsToGrams.Size = new System.Drawing.Size(140, 23);
            this.btnCalculateCupsToGrams.TabIndex = 14;
            this.btnCalculateCupsToGrams.Text = "Cups to &Grams";
            this.btnCalculateCupsToGrams.UseVisualStyleBackColor = true;
            this.btnCalculateCupsToGrams.Click += new System.EventHandler(this.btnCalculateCupsToGrams_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(28, 35);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(204, 15);
            this.lblDirections.TabIndex = 16;
            this.lblDirections.Text = "Input fields require decimal numbers.";
            // 
            // btnCalculateGramsToCups
            // 
            this.btnCalculateGramsToCups.Location = new System.Drawing.Point(105, 124);
            this.btnCalculateGramsToCups.Name = "btnCalculateGramsToCups";
            this.btnCalculateGramsToCups.Size = new System.Drawing.Size(140, 23);
            this.btnCalculateGramsToCups.TabIndex = 17;
            this.btnCalculateGramsToCups.Text = "Grams to &Cups";
            this.btnCalculateGramsToCups.UseVisualStyleBackColor = true;
            this.btnCalculateGramsToCups.Click += new System.EventHandler(this.btnCalculateGramsToCups_Click);
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHR.Location = new System.Drawing.Point(15, 157);
            this.lblHR.MaximumSize = new System.Drawing.Size(230, 2);
            this.lblHR.MinimumSize = new System.Drawing.Size(230, 2);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(230, 2);
            this.lblHR.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 315);
            this.label3.MaximumSize = new System.Drawing.Size(230, 2);
            this.label3.MinimumSize = new System.Drawing.Size(230, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 2);
            this.label3.TabIndex = 101;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 102;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DryWeightConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 363);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.btnCalculateGramsToCups);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateCupsToGrams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCups);
            this.Controls.Add(this.lblGrams);
            this.Controls.Add(this.txtGramsToCupsRoundedOutput);
            this.Controls.Add(this.lblRounded);
            this.Controls.Add(this.txtGramsToCupsOutput);
            this.Controls.Add(this.txtCupsToGramsOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCupsInput);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtGramsInput);
            this.Controls.Add(this.lblTitleDryWeightConversion);
            this.Controls.Add(this.lblGramsToCups);
            this.Controls.Add(this.lblCupsToGrams);
            this.Name = "DryWeightConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dry Weight Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCupsToGrams;
        private System.Windows.Forms.Label lblGramsToCups;
        private System.Windows.Forms.Label lblTitleDryWeightConversion;
        private System.Windows.Forms.TextBox txtGramsInput;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtCupsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCupsToGramsOutput;
        private System.Windows.Forms.TextBox txtGramsToCupsOutput;
        private System.Windows.Forms.Label lblRounded;
        private System.Windows.Forms.TextBox txtGramsToCupsRoundedOutput;
        private System.Windows.Forms.Label lblGrams;
        private System.Windows.Forms.Label lblCups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateCupsToGrams;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnCalculateGramsToCups;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
    }
}

