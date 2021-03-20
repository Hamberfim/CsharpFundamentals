/***************************************************************
* Name        : appMenusCreation
* Author      : Anthony Hamlin
* Created     : 03/20/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program is a simple proof for some application menu functions.       
***************************************************************/
using System;
using System.Windows.Forms;

namespace appMenusCreation
{
    public partial class appMenus : Form
    {
        public appMenus()
        {
            InitializeComponent();
        }

        // Menu actions - new
        private void newFile()
        {
            richTextBox1.Text = null;
            toolStripStatusLabel1.Text = "Ready";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newFile();
        }

        // Menu actions - open
        private void openFile()
        {
            openFileDialog1.Filter = "Text Files | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        // Menu actions - save
        private void saveFile()
        {
            saveFileDialog1.Filter = "Text Files | *.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        // Menu action - paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText(TextDataFormat.Text);
        }

        // menu action - about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "My Text App";
            string message = "Just a simple app to create functional application menus.";
            MessageBox.Show(message, title);
        }

        // menu action exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
