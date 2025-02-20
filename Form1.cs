using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ravi" && textBox2.Text == "1359")
            {  
               Form2 f=new Form2();
               this.Hide();
               f.Show();
               MessageBox.Show("VALID NAME", "Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID NAME", "Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
