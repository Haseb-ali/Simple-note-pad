using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simple_note_pad
{
    public partial class Form1 : Form
    {
        private string fn = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void itToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_Resize(object sender, EventArgs e)
        {
            
            richTextBox1.Height = 670;
            richTextBox1.Width = 1370;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "Text Document(*.txt)|*.txt|All files(*.)|*.doc|*.*|";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(f.FileName, RichTextBoxStreamType.PlainText);
                    fn = f.FileName;
                }
            }
            catch(System.Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength!=0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
            if(undoToolStripMenuItem.Enabled==false)
            {
                undoToolStripMenuItem.BackColor = Color.Red;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.Cut();
            }
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo(); }
        }

        private void chngecolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color1 = new ColorDialog();
            if(color1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.BackColor = color1.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fcolor = new ColorDialog();
            if (fcolor.ShowDialog() == DialogResult.OK)
            {
                string h = richTextBox1.SelectedText;
                int index = richTextBox1.Text.IndexOf(h);
                int lengt = h.Length;
                richTextBox1.Select(index, lengt);
                richTextBox1.SelectionColor = fcolor.Color;
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font1 = new FontDialog();
            if (font1.ShowDialog() == DialogResult.OK)
            {
                string fo = richTextBox1.SelectedText;
                int lenght = fo.Length;
                int index = richTextBox1.Text.IndexOf(fo);
                richTextBox1.Select(index, lenght);
                richTextBox1.SelectionFont = font1.Font;
            }
        }

        private void sellectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            contextMenuStrip1.Cursor = Cursors.Hand;
            int cols = richTextBox1.SelectionStart;
            int lines = richTextBox1.GetLineFromCharIndex(cols);
            lines0ToolStripMenuItem.Text="Words=" + cols;
            wordsToolStripMenuItem1.Text = "Lines=" + lines;
            int words = richTextBox1.SelectionStart;
            int  index = richTextBox1.GetLineFromCharIndex(words);
            wordsToolStripMenuItem.Text = "Words=" + words;
            linesToolStripMenuItem.Text = "Lines=" + index;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
            if(richTextBox1.TextLength==0)
            {
                undoToolStripMenuItem.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(richTextBox1.TextLength==0)
            {
                undoToolStripMenuItem.Enabled =false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void sellectAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DateTime.Now.ToLongDateString();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog coloR = new ColorDialog();
            if(coloR.ShowDialog()==DialogResult.OK)
            {
                string text = richTextBox1.SelectedText;
                int index = richTextBox1.Text.IndexOf(text);
                int lenght = text.Length;
                richTextBox1.Select(index, lenght);
                richTextBox1.SelectionColor = coloR.Color;
            }
        }

        private void fontToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FontDialog font1 = new FontDialog();
            if (font1.ShowDialog() == DialogResult.OK)
            {
                string fo = richTextBox1.SelectedText;
                int lenght = fo.Length;
                int index = richTextBox1.Text.IndexOf(fo);
                richTextBox1.Select(index, lenght);
                richTextBox1.SelectionFont = font1.Font;
            }
        }

        private void backgroundColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void backcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog Color = new ColorDialog();
            if (Color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = Color.Color;
            }
        }

        private void sellectedbackcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                string g = richTextBox1.SelectedText;
                int index = richTextBox1.Text.IndexOf(g);
                int l = g.Length;
                richTextBox1.Select(index,l);
                richTextBox1.SelectionBackColor = c.Color;
            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void wholeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if(f.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = f.Font;
            }
        }

        private void wholeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor = c.Color;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text Document (.txt)|*.txt|*.|";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            catch(System.Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(richTextBox1.TextLength!=0)
            {
                if(MessageBox.Show("Do you want to save changrs ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    SaveFileDialog sv = new SaveFileDialog();
                    sv.Filter = "text Document(*.txt)|.txt|All Files(*.)|*.*";
                    if(sv.ShowDialog()==DialogResult.OK)
                    {
                        richTextBox1.SaveFile(sv.FileName,RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        this.Close();
                    }
                }
           
            }

            
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void heloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength == 0)
            {
                undoToolStripMenuItem.Enabled = false;
            }
            if (richTextBox1.TextLength != 0)
            {
                undoToolStripMenuItem.Enabled = true;
            }
            if (richTextBox1.TextLength == 0)
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                sellectAllToolStripMenuItem.Enabled = false;
            }
            if (richTextBox1.TextLength != 0)
            {

                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                sellectAllToolStripMenuItem.Enabled = true;

            }
        }

        private void develporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form5 f = new Form5();
            f.ShowDialog();*/
            MessageBox.Show(fn);
        }

        private void rightToleftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void leftTorightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void selectedtextRTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.SelectedText;
            int index = richTextBox1.Text.IndexOf(text);
            int l = text.Length;
            richTextBox1.Select(index,l);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void righttoLeftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void lefttoRightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void aboutDevelporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 about = new Form4();
            about.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Rich text file(*.rtf)|*.rtf|plain text file(*.txt)|*.txt";
                richTextBox1.SaveFile(fn, RichTextBoxStreamType.PlainText);
            }
            catch(System.Exception E)
            {
                MessageBox.Show(E.Message);
            }
            }
    }
}
