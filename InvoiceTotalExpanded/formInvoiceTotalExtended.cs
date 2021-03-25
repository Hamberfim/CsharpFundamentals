/***************************************************************
* Name        : InvoiceTotalExpanded
* Author      : Anthony Hamlin
* Created     : 03/22/2021
* Version     : 1.5
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program calculates invoice totals and provides a discount based on the subtotal,
*               keeps a count of the number of subtotal invoices entered, the running total of all input
*               and provides an average of the invoices.
***************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotalExpanded
{
    public partial class formInvoiceTotalExtended : Form
    {
        // needed class vars for expanded area
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;
        decimal largestInvoice = 0m;
        decimal smallestInvoice = Decimal.MaxValue;

        public formInvoiceTotalExtended()
        {
            InitializeComponent();
        }

        // Calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                /*****************************************************
                *  This method calculates the total
                *  for an invoice depending on a
                *  discount that's based on the value of the subtotal
                ****************************************************/

                // decimal subtotal = Convert.ToDecimal(txtSubtotalEntry.Text);
                decimal subtotal = Decimal.Parse(txtSubtotalEntry.Text);
                decimal discountPercent = 0m;
                // determine discount percent based on subtotal value
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

                // calculate discount amount based on subtotal value
                decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
                decimal invoiceTotal = Math.Round(subtotal - discountAmount, 2);

                // set the value for the ready only text box display
                txtSubtotal.Text = subtotal.ToString("C");
                txtDiscountPercent.Text = discountPercent.ToString("p1");
                txtDiscountAmount.Text = discountAmount.ToString("C2");
                txtTotal.Text = invoiceTotal.ToString("C2");

                // calculated expanded field values
                numberOfInvoices++;
                totalOfInvoices += invoiceTotal;
                invoiceAverage = totalOfInvoices / numberOfInvoices;
                largestInvoice = Math.Max(largestInvoice, invoiceTotal);
                smallestInvoice = Math.Min(smallestInvoice, invoiceTotal);

                // set the values for the expanded area ready only text box display
                txtNumInvoices.Text = numberOfInvoices.ToString();
                txtTotalOfInvoices.Text = totalOfInvoices.ToString("C");
                txtInvoiceAvg.Text = invoiceAverage.ToString("C");
                txtLargestInvoice.Text = largestInvoice.ToString("C");
                txtSmallestInvoice.Text = smallestInvoice.ToString("C");

                txtSubtotalEntry.Text = "";
                txtSubtotalEntry.Focus();
            }
            catch (Exception error)
            {
                // display pop up message of the exception error
                Console.WriteLine(error.Message);
                string title = "Exception Error";
                MessageBox.Show(error.Message + " Numeric input required.", title);
            }

        }

        // clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;
            largestInvoice = 0m;
            smallestInvoice = Decimal.MaxValue;

            txtNumInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAvg.Text = "";
            txtLargestInvoice.Text = "";
            txtSmallestInvoice.Text = "";

            txtSubtotalEntry.Focus();
        }


        // exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
