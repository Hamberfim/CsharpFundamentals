/***************************************************************
* Name        : dryWeightConversion
* Author      : Anthony Hamlin
* Created     : 05/12/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : MIT 2021 Anthony Hamlin
*               specifications or project scope
* Description : Converts dry cup/gram weights        
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

namespace dryWeightConversion
{
    public partial class DryWeightConversion : Form
    {
        public DryWeightConversion()
        {
            InitializeComponent();
        }

        private void btnCalculateGramsToCups_Click(object sender, EventArgs e)
        {
            try
            {
                decimal grams = 0m;
                decimal cups = Convert.ToDecimal(txtGramsInput.Text);
                CupsToGrams(cups);
                // simple cups to grams formula -  grams = cups * 125
                decimal CupsToGrams(decimal cups)
                {
                    grams = cups * 125.0m;
                    return grams;
                }
                txtCupsToGramsOutput.Text = grams.ToString();
            }
            catch (Exception error)
            {
                // display pop up message of the exception error
                Console.WriteLine(error.Message);
                string title = "Exception Error";
                MessageBox.Show(error.Message + " Decimal input required.", title);
            }
            
        }

        private void btnCalculateCupsToGrams_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cups = 0.000m;
                decimal cupsDeci = 0.0m;
                decimal cupsQtr = 0.0m;

                decimal grams = Convert.ToDecimal(txtCupsInput.Text);
                GramsToCups(grams);
                // simple grams to cups formula -  cups = grams / 125
                (decimal cupsQtr, decimal cupsDeci) GramsToCups(decimal grams)
                {
                    cups = grams / 125.000m;
                    cupsDeci = Math.Round(cups, 2);
                    // rounding to nearest quarter  i.e. cups.25, cups.50 cups.75, cups.0
                    cupsQtr = Math.Round(cups * 4, MidpointRounding.ToEven) / 4;
                    // return the tuple
                    return (cupsQtr, cupsDeci);
                }
                txtGramsToCupsOutput.Text = cupsDeci.ToString();
                txtGramsToCupsRoundedOutput.Text = cupsQtr.ToString();
            }
            catch (Exception error)
            {
                // display pop up message of the exception error
                Console.WriteLine(error.Message);
                string title = "Exception Error";
                MessageBox.Show(error.Message + " Decimal input required.", title);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGramsInput.Text = "";
            txtCupsToGramsOutput.Text = "";
            txtCupsInput.Text = "";
            txtGramsToCupsOutput.Text = "";
            txtGramsToCupsRoundedOutput.Text = "";
        }
    }
}
