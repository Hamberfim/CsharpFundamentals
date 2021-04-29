
namespace enhancedInvoiceCustomerType
{
    partial class InvoiceTotal
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
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.txtBoxCustomerType = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.txtBoxDiscountPercent = new System.Windows.Forms.TextBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.txtBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(34, 26);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(84, 13);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "Customer Type: ";
            // 
            // txtBoxCustomerType
            // 
            this.txtBoxCustomerType.Location = new System.Drawing.Point(120, 22);
            this.txtBoxCustomerType.Name = "txtBoxCustomerType";
            this.txtBoxCustomerType.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCustomerType.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(66, 65);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(120, 61);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubtotal.TabIndex = 3;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(23, 104);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(95, 13);
            this.lblDiscountPercent.TabIndex = 4;
            this.lblDiscountPercent.Text = "Discount Percent: ";
            // 
            // txtBoxDiscountPercent
            // 
            this.txtBoxDiscountPercent.Location = new System.Drawing.Point(120, 100);
            this.txtBoxDiscountPercent.Name = "txtBoxDiscountPercent";
            this.txtBoxDiscountPercent.ReadOnly = true;
            this.txtBoxDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDiscountPercent.TabIndex = 5;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(24, 143);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(94, 13);
            this.lblDiscountAmount.TabIndex = 6;
            this.lblDiscountAmount.Text = "Discount Amount: ";
            // 
            // txtBoxDiscountAmount
            // 
            this.txtBoxDiscountAmount.Location = new System.Drawing.Point(120, 139);
            this.txtBoxDiscountAmount.Name = "txtBoxDiscountAmount";
            this.txtBoxDiscountAmount.ReadOnly = true;
            this.txtBoxDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDiscountAmount.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(81, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: ";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(120, 178);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotal.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 229);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(145, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InvoiceTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBoxDiscountAmount);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.txtBoxDiscountPercent);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtBoxCustomerType);
            this.Controls.Add(this.lblCustomerType);
            this.Name = "InvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.TextBox txtBoxCustomerType;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.TextBox txtBoxDiscountPercent;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.TextBox txtBoxDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

