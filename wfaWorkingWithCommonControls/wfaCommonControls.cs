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
        public wfaCommonControls()
        {
            InitializeComponent();
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
    }
}
