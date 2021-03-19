
namespace callSysDialog
{
    partial class callSysDialog
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtBoxLrg = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(13, 13);
            this.picBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.picBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 100);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtBoxLrg
            // 
            this.txtBoxLrg.Location = new System.Drawing.Point(120, 13);
            this.txtBoxLrg.MaximumSize = new System.Drawing.Size(250, 65);
            this.txtBoxLrg.MinimumSize = new System.Drawing.Size(250, 65);
            this.txtBoxLrg.Name = "txtBoxLrg";
            this.txtBoxLrg.Size = new System.Drawing.Size(250, 65);
            this.txtBoxLrg.TabIndex = 1;
            this.txtBoxLrg.Text = "Calling System Dialogs";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(120, 90);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Form Color";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(197, 90);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Text Box Font";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(294, 90);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Picture Box";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // callSysDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 173);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBoxLrg);
            this.Controls.Add(this.picBox);
            this.Name = "callSysDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call System Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtBoxLrg;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

