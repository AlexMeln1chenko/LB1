using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "Введите текст";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "Введите текст";
                button3.Enabled = false;
                button3.BackColor = Color.DarkGray;
            }
            else
            {
                label1.Text = " ";
                button3.Enabled = true;
                button3.BackColor = Color.Gainsboro;
            }
        }
    }
}
