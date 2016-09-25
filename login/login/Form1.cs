using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="admin")
            {
                if(textBox2.Text == "123")
                {
                    MessageBox.Show(textBox1.Text + ",Hello~!");
                }
                else
                {
                    MessageBox.Show("Your Password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Your ID is incorrect");
            }
            
        }
    }
}
