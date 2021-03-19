
namespace messageBoxe
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
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.txtBoxMessageResult = new System.Windows.Forms.TextBox();
            this.lblProgramRunning = new System.Windows.Forms.Label();
            this.lblDialogResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(23, 23);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(231, 23);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Show Message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // txtBoxMessageResult
            // 
            this.txtBoxMessageResult.Location = new System.Drawing.Point(102, 62);
            this.txtBoxMessageResult.Name = "txtBoxMessageResult";
            this.txtBoxMessageResult.Size = new System.Drawing.Size(152, 20);
            this.txtBoxMessageResult.TabIndex = 1;
            // 
            // lblProgramRunning
            // 
            this.lblProgramRunning.AutoSize = true;
            this.lblProgramRunning.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramRunning.Location = new System.Drawing.Point(62, 100);
            this.lblProgramRunning.Name = "lblProgramRunning";
            this.lblProgramRunning.Size = new System.Drawing.Size(157, 18);
            this.lblProgramRunning.TabIndex = 2;
            this.lblProgramRunning.Text = "Program is Running...";
            // 
            // lblDialogResult
            // 
            this.lblDialogResult.AutoSize = true;
            this.lblDialogResult.Location = new System.Drawing.Point(20, 65);
            this.lblDialogResult.Name = "lblDialogResult";
            this.lblDialogResult.Size = new System.Drawing.Size(76, 13);
            this.lblDialogResult.TabIndex = 3;
            this.lblDialogResult.Text = "Dialog Result: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 149);
            this.Controls.Add(this.lblDialogResult);
            this.Controls.Add(this.lblProgramRunning);
            this.Controls.Add(this.txtBoxMessageResult);
            this.Controls.Add(this.btnShowMessage);
            this.Name = "Form1";
            this.Text = "Message Box Eample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.TextBox txtBoxMessageResult;
        private System.Windows.Forms.Label lblProgramRunning;
        private System.Windows.Forms.Label lblDialogResult;
    }
}

