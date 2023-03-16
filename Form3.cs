using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kalkulator___Jovan_Dragas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovo je long kalkulator. Gumbovi sa brojevima ne sluze nicemu, samo su tu radi lepote. Unesite brojeve preko tastature.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Long a = new Long(textBox1.Text);
            Long b = new Long(textBox2.Text);
            Long c = a + b;
            textBox3.Text = c.broj;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Long a = new Long(textBox1.Text);
            Long b = new Long(textBox2.Text);
            Long c = a - b;
            textBox3.Text = c.broj;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Long a = new Long(textBox1.Text);
            Long b = new Long(textBox2.Text);
            Long c = a * b;
            textBox3.Text = c.broj;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamisli da se ugasio i prekini kod", "ne znam kako");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Long a = new Long(textBox1.Text);
            Long b = new Long(textBox2.Text);
            Long c = a / b;
            textBox3.Text = c.broj;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
