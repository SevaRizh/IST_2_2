using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string s;
        double a;
        double b;
        double c;
//        string S;
        double A, B, C, D, E, F, G, H;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                a = 0;
            }
            else
            {
                s = textBox1.Text;
                a = Convert.ToDouble(s);
            }

            textBox3.Text = "Идет расчет";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                b = 0;
            }
            else
            {
                s = textBox2.Text;
                b = Convert.ToDouble(s);
            }

            c = a + b;

            textBox3.Text = Convert.ToString(c);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                A = 0;
            }
            else
            {
                A = Convert.ToDouble(textBox4.Text);
            }

            textBox12.Text = "Не хватает данных";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                B = 0;
            }
            else
            {
                B = Convert.ToDouble(textBox5.Text);
            }

            textBox12.Text = "Укажите степень";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                C = 0;
            }
            else
            {
                C = Convert.ToDouble(textBox6.Text);
            }

            textBox12.Text = "Не хватает делителя";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                D = 0;
            }
            else
            {
                D = Convert.ToDouble(textBox7.Text);
            }

            textBox12.Text = "Добавьте множетель";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                E = 0;
            }
            else
            {
                E = Convert.ToDouble(textBox8.Text);
            }

            textBox12.Text = "Напишите слагаемое";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                F = 0;
            }
            else
            {
                F = Convert.ToDouble(textBox9.Text);
            }

            textBox12.Text = "Где делитель?";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                G = 0;
            }
            else
            {
                G = Convert.ToDouble(textBox10.Text);
            }

            textBox12.Text = "Укажите слагаемое";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                H = 0;
            }
            else
            {
                H = Convert.ToDouble(textBox11.Text);
            }

            textBox12.Text = Convert.ToString(Math.Round((Math.Pow(A + B, C) / D * E + F) / G + H, 3));

        }
    }
}
