using System;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ТoggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ТoggleMenuItem.Checked)
            {
                ТoggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ТoggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private String BufferText;

        //Text cutting
        public void Cut()
        {
            this.BufferText = ChildTextBox.SelectedText;
            ChildTextBox.SelectedText = "";
        }

        //Copying text
        public void Copy()
        {
            this.BufferText = ChildTextBox.SelectedText;
        }

        //Paste
        public void Paste()
        {
            ChildTextBox.SelectedText = this.BufferText;
        }

        //Select all text
        public void SelectAll()
        {
            ChildTextBox.SelectAll();
        }

        //Delete
        public void Delete()
        {
            ChildTextBox.SelectedText = "";
            this.BufferText = "";
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            this.Cut();
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            this.Copy();
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            this.Paste();
        }

        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
