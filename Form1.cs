using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator___Jovan_Dragas
{
    public partial class Form1 : Form
    {
        Kalkulator Kalkulator = new Kalkulator();
        public static TextBox izraz;
        public static Form2 vrednost;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^2";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "i";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += " x ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Kalkulator.prepoznaj(textBox1.Text);
            textBox1.Text = Kalkulator.rez();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
