using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generateLottoNumbers
{
    public partial class FormLottoNumberPicker : Form
    {
        public FormLottoNumberPicker()
        {
            InitializeComponent();
        }

        // clear method
        private void Clear()
        {
            // default start state of number lables
            lblNum1.Text = "...";
            lblNum2.Text = "...";
            lblNum3.Text = "...";
            lblNum4.Text = "...";
            lblNum5.Text = "...";
            lblNum6.Text = "...";

            // set the button state for starting
            btnPick.Enabled = true;
            btnReset.Enabled = false;
        }

        // load form event handler(s)
        private void LottoNumberPicker_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // random number picker
        private void btnPick_Click(object sender, EventArgs e)
        {
            // generate random number array and shuffle the array
            Random rnd = new Random();

            // array
            int[] seq = new int[59];

            // fill the array
            for (int i = 1; i < 60; i++)
            {
                seq[i - 1] = i;
            }

            // shuffle the array - randomize algorithm
            for (int i = 0; i < 59; i++)
            {
                int randomize1 = (rnd.Next() % 59);
                int randomize2 = seq[i];
                seq[i] = seq[randomize1];
                seq[randomize1] = randomize2;

            }

            // display the number label - random numbers values 
            lblNum1.Text = seq[1].ToString();
            lblNum2.Text = seq[2].ToString();
            lblNum3.Text = seq[3].ToString();
            lblNum4.Text = seq[4].ToString();
            lblNum5.Text = seq[5].ToString();
            lblNum6.Text = seq[6].ToString();

            // re-set the button states as Finished
            btnPick.Enabled = false;
            btnReset.Enabled = true;

        }
    }
}
