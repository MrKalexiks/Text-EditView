using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditView.App
{
    public partial class Main : Form
    {

        string SavedFile = "";
        public Main()
        {
            InitializeComponent();
        }

        private void SaveAsFileButton_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("You closed window to saving file.", "Text EditView");
                return;
            }
            else
            {
                System.IO.File.WriteAllText(SaveFileDialog.FileName, InputText.Text);
                SavedFile = SaveFileDialog.FileName;
                MessageBox.Show("Successed save file.", "Text EditView");
            }

        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("You closed window to opening file.", "Text EditView");
                return;
            }
            else
            {
                InputText.Text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
                MessageBox.Show("Successed read file.", "Text EditView");
            }
        }

        private void CopyTextButton_Click(object sender, EventArgs e)
        {
            InputText.Copy();
            
        }

        private void PasteTextButton_Click(object sender, EventArgs e)
        {
            InputText.Paste();
        }

        private void CutTextButton_Click(object sender, EventArgs e)
        {
            InputText.Cut();
        }

        private void SelectAllTextButton_Click(object sender, EventArgs e)
        {
            InputText.SelectAll();
        }

        private void ChooseBackgroundButton_Click(object sender, EventArgs e)
        {
            if (SelectColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("You closed window to select background.", "Text EditView");
                return;
            }
            else
            {
                MessageBox.Show("Successed change background.", "Text EditView");
                InputText.BackColor = SelectColorDialog.Color;
            }
        }

        private void ChooseFontButton_Click(object sender, EventArgs e)
        {
            if (FontChooserDialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("You closed window to select font.", "Text EditView");
                return;
            }
            else
            {
                MessageBox.Show("Successed change font.", "Text EditView");
                InputText.Font = FontChooserDialog.Font;
            }
        }

        private void CopyTextHelper_Click(object sender, EventArgs e)
        {
            InputText.Copy();
        }

        private void PasteTextHelper_Click(object sender, EventArgs e)
        {
            InputText.Paste();
        }

        private void CutTextHelper_Click(object sender, EventArgs e)
        {
            InputText.Cut();
        }

        private void SelectAllTextHelper_Click(object sender, EventArgs e)
        {
            InputText.SelectAll();
        }

        private void InputText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                InputText.ContextMenuStrip = InputHelper;
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (SavedFile == "")
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("You closed window to saving file.", "Text EditView");
                    return;
                }
                else
                {
                    System.IO.File.WriteAllText(SaveFileDialog.FileName, InputText.Text);
                    SavedFile = SaveFileDialog.FileName;
                    MessageBox.Show("Successed save file.", "Text EditView");
                }
            }
            else
            {
                System.IO.File.WriteAllText(SavedFile, InputText.Text);
                MessageBox.Show("Successed save file.", "Text EditView");
            }
        }
    }
}
