
namespace wfaWorkingWithCommonControls
{
    partial class wfaCommonControls
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
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.lblWordChange = new System.Windows.Forms.Label();
            this.btnChangeWords = new System.Windows.Forms.Button();
            this.btnShowMessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.Location = new System.Drawing.Point(55, 9);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(307, 18);
            this.lblTitleHeader.TabIndex = 0;
            this.lblTitleHeader.Text = "Just messing with common controls in WFA";
            // 
            // lblWordChange
            // 
            this.lblWordChange.AutoSize = true;
            this.lblWordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordChange.Location = new System.Drawing.Point(56, 54);
            this.lblWordChange.Name = "lblWordChange";
            this.lblWordChange.Size = new System.Drawing.Size(225, 16);
            this.lblWordChange.TabIndex = 1;
            this.lblWordChange.Text = "Click Button to changes these Words";
            // 
            // btnChangeWords
            // 
            this.btnChangeWords.Location = new System.Drawing.Point(287, 51);
            this.btnChangeWords.Name = "btnChangeWords";
            this.btnChangeWords.Size = new System.Drawing.Size(75, 23);
            this.btnChangeWords.TabIndex = 2;
            this.btnChangeWords.Text = "Click Me!";
            this.btnChangeWords.UseVisualStyleBackColor = true;
            this.btnChangeWords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeWords_MouseClick);
            this.btnChangeWords.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnChangeWords_MouseDown);
            this.btnChangeWords.MouseLeave += new System.EventHandler(this.btnChangeWords_MouseLeave);
            this.btnChangeWords.MouseHover += new System.EventHandler(this.btnChangeWords_MouseHover);
            // 
            // btnShowMessageBox
            // 
            this.btnShowMessageBox.Location = new System.Drawing.Point(56, 100);
            this.btnShowMessageBox.Name = "btnShowMessageBox";
            this.btnShowMessageBox.Size = new System.Drawing.Size(304, 23);
            this.btnShowMessageBox.TabIndex = 3;
            this.btnShowMessageBox.Text = "Click me to Show Message Box";
            this.btnShowMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMessageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnShowMessageBox_MouseClick);
            this.btnShowMessageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowMessageBox_MouseDown);
            this.btnShowMessageBox.MouseLeave += new System.EventHandler(this.btnShowMessageBox_MouseLeave);
            this.btnShowMessageBox.MouseHover += new System.EventHandler(this.btnShowMessageBox_MouseHover);
            // 
            // wfaCommonControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.btnShowMessageBox);
            this.Controls.Add(this.btnChangeWords);
            this.Controls.Add(this.lblWordChange);
            this.Controls.Add(this.lblTitleHeader);
            this.Name = "wfaCommonControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WFA - Some Common Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHeader;
        private System.Windows.Forms.Label lblWordChange;
        private System.Windows.Forms.Button btnChangeWords;
        private System.Windows.Forms.Button btnShowMessageBox;
    }
}

