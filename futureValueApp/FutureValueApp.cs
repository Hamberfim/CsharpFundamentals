using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futureValue
{
    public partial class FutureValueApp : Form
    {
        public FutureValueApp()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal yearlyInterestrate = Convert.ToDecimal(txtYearlyInterestRate.Text);
                int years = Convert.ToInt32(txtNumberOfYears.Text);

                int months = years * 12;
                decimal monthlyInterestrate = yearlyInterestrate / 12 / 100;

                decimal futureValue = 0m;
                for (int i = 0; i < months; i++)
                {
                    futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestrate);
                }

                txtFutureValue.Text = futureValue.ToString("C");
                txtMonthlyInvestment.Focus();
                
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
