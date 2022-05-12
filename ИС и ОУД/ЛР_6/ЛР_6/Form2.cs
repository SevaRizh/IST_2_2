using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_6
{
    public partial class Form2 : Form
    {
        private int counter = 0;
        private ImageList imageList1;

        public Form2()
        {
            InitializeComponent();
            imageList1 = new ImageList();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Images (*.jpg; *.jpeg; *.gif; *.bmp; *.ico; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.ico; *.png";
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imageList1.Images.Add(Image.FromFile(openFileDialog1.FileName));
                }
            }
        }

        private void buttodAdd_Click(object sender, EventArgs e)
        {
            //  Проверка на наличие данных в полях ввода и изображения, если чего то нет - return
            //  imageList1.Images.Empty - для полноты оставлено, без него тоже работает корректно
            if (string.IsNullOrEmpty(textBoxID.Text) ||
                string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxGroup.Text) ||
                string.IsNullOrEmpty(textBoxValue.Text) ||
                imageList1.Images.Empty == true ||
                imageList1.Images.Count - 1 != counter)
            {
                MessageBox.Show("Указаны не все данны\n\nНет возможности построить таблицу!!!");
                return;
            }

            DataGridViewCell id = new DataGridViewTextBoxCell();
            DataGridViewCell name = new DataGridViewTextBoxCell();
            DataGridViewCell group = new DataGridViewTextBoxCell();
            DataGridViewCell value = new DataGridViewTextBoxCell();
            DataGridViewCell image = new DataGridViewImageCell();
            //заполнение ячеек
            id.Value = textBoxID.Text;
            name.Value = textBoxName.Text;
            group.Value = textBoxGroup.Text;
            value.Value = textBoxValue.Text;
            image.Value = imageList1.Images[counter++];
            image.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //создание строки
            DataGridViewRow row = new DataGridViewRow();
            //добавление ячеек в строку
            row.Cells.AddRange(id, name, group, value, image);
            //добавление строки в таблицу
            dataGridView1.Rows.Add(row);
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxGroup.Clear();
            textBoxValue.Clear();
            //обновляем таблицу
            dataGridView1.Refresh();
            textBoxID.Select();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
//            counter = 0;
        }

        private void Load_Form2(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Название";
            dataGridView1.Columns[2].Name = "Группа";
            dataGridView1.Columns[3].Name = "Количество";
            dataGridView1.Columns[4].Name = "Изображение";
        }

        //  В textBoxID можно вводить только цифры
        private void textBoxID_Key(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //  В textBoxValue можно вводить только цифры
        private void textBoxValue_Key(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
