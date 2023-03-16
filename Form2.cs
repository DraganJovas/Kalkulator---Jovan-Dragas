using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator___Jovan_Dragas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Rimski r = new Rimski();

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "x";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "M";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "I";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "V";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "L";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "D";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamisli da se ugasio i prekini kod", "ne znam kako");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            r.ac();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            r.prepoznajR(textBox1.Text);
            r.prviRInt();
            r.drugiRInt();
            textBox1.Text = r.rezR();
            
        }
    }
}
