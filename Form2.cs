using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234567891" && textBox2.Text =="Ravi" && textBox3.Text == "ravi@gmail.com")
            {
                MessageBox.Show("VALID NAME", "TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID NAME", "TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
