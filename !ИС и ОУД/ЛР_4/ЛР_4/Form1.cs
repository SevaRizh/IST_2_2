using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) return;

            listBox1.Items.Add(textBox1.Text);

            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
            textBox3.Text = listBox1.SelectedIndex.ToString();
            textBox4.Text = listBox1.Items.Count.ToString();

            if (listBox1.Items.Count == 0) 
                textBox5.Text = "Список пустой";
            else 
                textBox5.Text = "Список не пуст!";

            if (listBox1.SelectedIndex > 0)
                textBox6.Text = listBox1.Items[listBox1.SelectedIndex - 1].ToString();
            else
                textBox6.Text = "---";

            if (listBox1.SelectedIndex < (listBox1.Items.Count - 1))
                textBox7.Text = listBox1.Items[listBox1.SelectedIndex + 1].ToString();
            else
                textBox7.Text = "---";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox8.Text.Length > 0)
            {
                if(Convert.ToInt16(textBox8.Text) >= 0 && 
                    Convert.ToInt16(textBox8.Text) < listBox1.Items.Count)
                {
                    textBox9.Text = "Да";
                    textBox10.Text = listBox1.Items[Convert.ToInt16(textBox8.Text)].ToString();
                }
                else
                {
                    textBox9.Text = "Нет";
                    textBox10.Text = "---";
                }
            }
        }
    }
}
