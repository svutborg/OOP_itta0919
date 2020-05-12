using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        FileInfo currentFile;

        public FileInfo CurrentFile
        {
            get => currentFile;
            set
            {
                currentFile = value;
                if (currentFile == null)
                {
                    this.Text = "Untitled - Simple Text Editor";
                }
                else
                {
                    this.Text = currentFile.Name + " - Simple Text Editor";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            CurrentFile = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            CurrentFile = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            CurrentFile = new FileInfo(openFileDialog1.FileName);
            if (CurrentFile.Extension == ".rtf")
            {
                richTextBox1.LoadFile(CurrentFile.FullName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.LoadFile(CurrentFile.FullName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFile(new FileInfo(saveFileDialog1.FileName));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile != null)
            {
                saveFile(CurrentFile);
            }
            else
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveFile(FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".rtf")
            {
                richTextBox1.SaveFile(fileInfo.FullName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.SaveFile(fileInfo.FullName, RichTextBoxStreamType.PlainText);
            }
            currentFile = fileInfo;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
        }
    }
}
