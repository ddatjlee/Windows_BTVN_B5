using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private string currentFilePath = "";
        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            float selectedSize = Convert.ToSingle(tscSize.SelectedItem);
            string currentFont = richTextBox1.SelectionFont.FontFamily.Name;
            richTextBox1.SelectionFont = new Font(currentFont, selectedSize);
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog()
            {
                ShowColor = true,
                ShowApply = true,
                ShowEffects = true,
                ShowHelp = true
            };
            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDialog.Color;
                richTextBox1.Font = fontDialog.Font;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tscFont.Text = "Tahoma";
            tscSize.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tscFont.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                tscSize.Items.Add(s);
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            tscFont.Text = "Tahoma";
            tscSize.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                if (openFileDialog.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.Text = System.IO.File.ReadAllText(currentFilePath);
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold)
                style &= ~FontStyle.Bold;
            else
                style |= FontStyle.Bold;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Italic)
                style &= ~FontStyle.Italic;
            else
                style |= FontStyle.Italic;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Underline)
                style &= ~FontStyle.Underline;
            else
                style |= FontStyle.Underline;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            string selectedFont = tscFont.SelectedItem.ToString();
            float currentSize = richTextBox1.SelectionFont.Size;
            richTextBox1.SelectionFont = new Font(selectedFont, currentSize);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            tscFont.Text = "Tahoma";
            tscSize.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            tscFont.Text = "Tahoma";
            tscSize.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
