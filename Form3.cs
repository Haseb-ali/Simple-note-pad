using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_note_pad
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Your use of this software is subject to the terms and conditions of the license agreement by which you acquired this software.  If you are a volume license customer, use of this software is subject to your volume license agreement.  You may not use this software if you have not validly acquired a license for the software from Microsoft or its licensed distributors.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
