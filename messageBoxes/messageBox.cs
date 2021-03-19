using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageBoxe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();  // TODO: temp NotImplementedException - remove/complete/add later
            }
            catch (NotImplementedException notImplemented)
            {
                // dialog - user response to var                                        MessageBoxButtons Constants, MessageBoxIcon Constants
                DialogResult result = MessageBox.Show("Proceed? ", notImplemented.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                txtBoxMessageResult.Text = result.ToString();

                if(result == DialogResult.Yes)
                {
                    lblProgramRunning.Text = "Proceeding...";
                }

                if(result == DialogResult.No)
                {
                    lblProgramRunning.Text = "Stopping...";
                }
            }
        }
    }
}
