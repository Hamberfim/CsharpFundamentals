using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callSysDialog
{
    public partial class callSysDialog : Form
    {
        public callSysDialog()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxLrg.Font = fontDialog1.Font;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error + " Select an image file");
                }
            }
        }
    }
}
