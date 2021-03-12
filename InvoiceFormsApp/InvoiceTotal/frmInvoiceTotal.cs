using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                /*****************************************************
                *  This method calculates the total
                *  for an invoice depending on a
                *  discount that's based on the value of the subtotal
                ****************************************************/
                // get the subtotal amount from the subtotal text box
                decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
                decimal discountPercent = 0m;
                if (subtotal >= 500)
                {
                    discountPercent = .2m;
                }
                else if (subtotal >= 250 && subtotal < 500)
                {
                    discountPercent = .15m;
                }
                else if (subtotal >= 100 && subtotal < 250)
                {
                    discountPercent = .1m;
                }

                // Calculate and assign the values for the discountAmount and invoiceTotal variables
                decimal discountAmount = subtotal * discountPercent;
                decimal invoiceTotal = subtotal - discountAmount;

                txtDicountPercent.Text = discountPercent.ToString("p1");  // format the values for display
                txtDiscountAmount.Text = discountAmount.ToString("c");  // format the values for display
                txtTotal.Text = invoiceTotal.ToString("c");

                // move focus to subtotal text box
                txtSubtotal.Focus();

            }
            catch (Exception error)
            {
                // display pop up message of the exception error
                Console.WriteLine(error.Message);
                string title = "Exception Error";
                MessageBox.Show(error.Message + " Numeric input required.", title);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
