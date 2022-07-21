using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            textBox3.Text = Convert.ToString(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = Math.Round((a * b) / (a + b) - 1, 3);
            textBox6.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox7.Text);
            double b = Convert.ToDouble(textBox8.Text);
            double c = Math.Round(Math.Pow(a, b) / Math.Pow(b, a), 3);
            textBox9.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox10.Text);
            double b = Convert.ToDouble(textBox11.Text);
            double c = Math.Round(Math.Pow((a + b), a) / Math.Pow((a + b), b), 3);
            textBox12.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox13.Text);
            double b = Convert.ToDouble(textBox14.Text);
            double c = (a + b)*(Math.Pow(a, 2) - a * b + Math.Pow(b, 2));
            textBox15.Text = Convert.ToString(c);
        }
    }
}
