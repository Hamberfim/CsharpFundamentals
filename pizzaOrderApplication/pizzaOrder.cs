using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaOrderApplication
{
    public partial class pizzaOrder : Form
    {
        public pizzaOrder()
        {
            InitializeComponent();

            // set default crust selection
            rdBtnThinCrust.Checked = true;
        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            lstbIngredientList.Items.Clear();

            // logic to add items to the listbox
            double priceTotal = 0;
            // crust type
            if (rdBtnThinCrust.Checked)
            {
                priceTotal = priceTotal + 3.99;
                lstbIngredientList.Items.Add(rdBtnThinCrust.Text);
            }
            if (rdBtnNYHandTossed.Checked)
            {
                priceTotal = priceTotal + 3.99;
                lstbIngredientList.Items.Add(rdBtnNYHandTossed.Text);
            }
            if (rdBtnChicagoDeepDish.Checked)
            {
                priceTotal = priceTotal + 3.99;
                lstbIngredientList.Items.Add(rdBtnChicagoDeepDish.Text);
            }
            // toppings
            if (chbCheese.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbCheese.Text);
            }
            if (chbPepperoni.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbPepperoni.Text);
            }
            if (chbSausage.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbSausage.Text);
            }
            if (chbMushrooms.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbMushrooms.Text);
            }
            if (chbOnions.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbOnions.Text);
            }
            if (chbGreenOlives.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbGreenOlives.Text);
            }
            if (chbBlackOlives.Checked)
            {
                priceTotal = priceTotal + 1.25;
                lstbIngredientList.Items.Add(chbBlackOlives.Text);
            }

            // add price total to listbox
            string orderTotal = $"Order Total: {priceTotal:C}";
            lstbIngredientList.Items.Add(orderTotal);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbIngredientList.Items.Clear();

            // set default crust selection
            rdBtnThinCrust.Checked = true;
            chbCheese.Checked = false;
            chbPepperoni.Checked = false;
            chbSausage.Checked = false;
            chbMushrooms.Checked = false;
            chbOnions.Checked = false;
            chbGreenOlives.Checked = false;
            chbBlackOlives.Checked = false;
        }
    }
}
