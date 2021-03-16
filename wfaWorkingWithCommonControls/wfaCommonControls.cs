using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaWorkingWithCommonControls
{
    public partial class wfaCommonControls : Form
    {
        private int number;
        public void setNumber(int num)
        {
            this.number = num;
        }

        public int getNumber()
        {
            return number;
        }
        public wfaCommonControls()
        {
            InitializeComponent();
            Random rnd = new Random();
            setNumber(rnd.Next(1, 21));
        }

        // method to indicate guess is high or low
        public void indicateGuess(int guess, int num)
        {
            if (guess < num)
            {
                lblHighLowGuessIndicator.Text = "Too Low!";
            }
            else if (guess > num)
            {
                lblHighLowGuessIndicator.Text = "Too High!";
            }
            else lblHighLowGuessIndicator.Text = "!!! CORRECT !!!";
        }

        private void btnChangeWords_MouseHover(object sender, EventArgs e)
        {
            lblWordChange.ForeColor = Color.Orange;
            btnChangeWords.BackColor = Color.Orange;
        }

        private void btnChangeWords_MouseLeave(object sender, EventArgs e)
        {
            lblWordChange.ForeColor = SystemColors.ControlText;
            btnChangeWords.BackColor = default(Color);
        }

        private void btnChangeWords_MouseClick(object sender, MouseEventArgs e)
        {
            lblWordChange.Text = "These words have changed!";
            lblWordChange.Refresh();
        }

        private void btnChangeWords_MouseDown(object sender, MouseEventArgs e)
        {
            btnChangeWords.BackColor = Color.Red;
        }

        private void btnShowMessageBox_MouseHover(object sender, EventArgs e)
        {
            btnShowMessageBox.BackColor = Color.Orange;
        }

        private void btnShowMessageBox_MouseLeave(object sender, EventArgs e)
        {
            btnShowMessageBox.BackColor = default(Color);
        }

        private void btnShowMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            btnShowMessageBox.BackColor = Color.Red;
        }

        private void btnShowMessageBox_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Pop-Up Message Box - Alert";
            string message = "C# seems more enjoyable than JAVA.";
            MessageBox.Show(message, title);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Convert.ToInt16(txtGuessBox.Text);
                indicateGuess(guess, getNumber());
            }
            catch (Exception error)
            {
                string title = "Alert - Exception error!";
                string message = "Your guess must be a whole number.";
                MessageBox.Show(error.Message + "\n" + message, title);
            }
            
        }
    }
}
