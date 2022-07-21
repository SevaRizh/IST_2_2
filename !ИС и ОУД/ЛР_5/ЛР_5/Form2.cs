using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_5
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num;

            if (textBox1.Text != string.Empty)
            {
                num = Convert.ToInt32(textBox1.Text.ToString());
                
                if (num > 9 || num < 1)
                {
                    num = rnd.Next(1, 9);
                    textBox1.Text = num.ToString();
                }
            }
            else
            {
                num = 5;
                textBox1.Text = num.ToString();
            }

            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 15;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    dataGridView1[i, j].Value = num++;
                }
                num /= 2;
            }
        }

        private void textBox1_Key(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }
    }
}
