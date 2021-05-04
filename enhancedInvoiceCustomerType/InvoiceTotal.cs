using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enhancedInvoiceCustomerType
{
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtBoxCustomerType.Text.ToUpper();  // make sure the input is upper case
            decimal subtotal = Convert.ToDecimal(txtBoxSubtotal.Text);
            decimal discountPercent = .0m;

            if(customerType == "R")
            {
                if(subtotal < 100)
                {
                    discountPercent = .0m;
                }
                else if(subtotal >= 100 && subtotal < 250)
                {
                    discountPercent = .1m;
                }
                else if(subtotal >= 250 && subtotal < 500)
                {
                    discountPercent = .25m;
                }
                else if (subtotal >= 500)
                {
                    discountPercent = .30m;
                }

            }
            else if(customerType == "C")
            {
                discountPercent = .2m;
            }
            else if (customerType == "T")
            {
                if (subtotal < 500)
                {
                    discountPercent = .4m;
                }
                else if(subtotal >= 500)
                {
                    discountPercent = .5m;
                }
            }
            else
            {
                discountPercent = .1m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtBoxDiscountPercent.Text = discountPercent.ToString("P1");
            txtBoxDiscountAmount.Text = discountAmount.ToString("C");
            txtBoxTotal.Text = invoiceTotal.ToString("C");

            txtBoxCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
