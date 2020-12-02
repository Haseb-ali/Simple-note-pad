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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Microsoft Windows\nVersion 1803(Os Build 17134.137)\n2018 Microsoft Corposition.All rights reserved.\nThe window 10 Home operating system and its user\n interface are protected by trademark and other pending\nor existing intellectual property rights in the Unite Sataes\nand other countries/regions.";
            label3.Text = "-----------------------------------------------------------------------------------------------------------------------------------------------------";
            label4.Text = "This Prodecut is licensed under the";
            linkLabel1.Text="Micrsoft Software Lincense Terms";
            label5.Text = "to:\n    HP";
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            linkLabel1.LinkVisited =false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
        }
    }
}
