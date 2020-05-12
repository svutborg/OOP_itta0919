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

namespace Ex5._4
{
    public partial class Form1 : Form
    {
        FileInfo document;
        bool changed;

        public FileInfo Document
        {
            get => document;
            set
            {
                document = value;
                updateTitle();
            }
        }

        public bool Changed 
        { 
            get => changed;
            set
            {
                if (changed != value) // onlye do this if status actually changes
                {
                    changed = value;
                    updateTitle();
                }
            }
        }

        private void updateTitle()
        {
            char changed = Changed == true ? '*' : ' ';
            string file = Document == null ? "untitled" : Document.Name;
            this.Text = $"{changed} {file} - TextEditor";
        }

        public Form1()
        {
            InitializeComponent();
            Document = null;
            Changed = false;
            profanitiesListBox.Items.Add("test");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Changed = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (document == null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                richTextBox1.SaveFile(document.FullName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            Document = new FileInfo(openFileDialog1.FileName);
            Changed = false;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            Document = new FileInfo(saveFileDialog1.FileName);
            Changed = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Changed = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Do you want to save before exitting the application?\nAll unsaved changes will be lost.",
                "Save before exitting?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);
            switch (res)
            {
                case DialogResult.Yes:
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;
                case DialogResult.No:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                default:
                    break;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void activateFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activateFilterToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void showFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showFilterToolStripMenuItem.Checked)
            {
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void profanitiesAddButton_Click(object sender, EventArgs e)
        {
            profanitiesListBox.Items.Add(profanitiesTextBox.Text);
        }

        private void profanitiesRemoveButton_Click(object sender, EventArgs e)
        {
            profanitiesListBox.Items.Remove(profanitiesListBox.SelectedItem);
        }

        private void profanitiesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                profanitiesAddButton_Click(sender, e);
                profanitiesTextBox.Clear();
            }
        }

        private void profanitiesClearButton_Click(object sender, EventArgs e)
        {
            profanitiesListBox.Items.Clear();
        }

        private void profanitiesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (profanitiesCheckBox.Checked)
            {
                profanitiesTimer.Start();
                profanitiesTimer_Tick(null, null);
            }
            else
            {
                profanitiesTimer.Stop();
            }
        }

        private void profanitiesTimer_Tick(object sender, EventArgs e)
        {
            foreach(string word in profanitiesListBox.Items)
            {
                string replacement = new string('*', word.Length);
                int index = richTextBox1.Text.IndexOf(word);
                while (index > -1)
                {
                    int cursorPos = richTextBox1.SelectionStart;
                    richTextBox1.Select(index, word.Length);
                    richTextBox1.SelectedText = replacement;
                    index = richTextBox1.Text.IndexOf(word);
                    richTextBox1.SelectionStart = cursorPos;
                }
            }
        }
    }
}
