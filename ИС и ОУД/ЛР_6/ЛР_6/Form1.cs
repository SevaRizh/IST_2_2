namespace ЛР_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Указываем, что колонок(столбцов) с данными будет пять
            dataGridView1.ColumnCount = 5;
            //Задаем имена столбцов
            dataGridView1.Columns[0].Name = "Номер товара";
            dataGridView1.Columns[1].Name = "ID товара";
            dataGridView1.Columns[2].Name = "Название товара";
            dataGridView1.Columns[3].Name = "Цена товара";
            dataGridView1.Columns[4].Name = "Количество";
            //Добавляем строки данных
            string[] row = new string[] { "1", "513", "Товар 1", "1000", "5" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "243", "Товар 2", "2000", "1" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "521", "Товар 3", "3000", "8" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "123", "Товар 4", "4000", "2" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "5", "256", "Товар 5", "1500", "4" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "6", "117", "Товар 6", "3500", "7" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "7", "311", "Товар 7", "1100", "3" };
            dataGridView1.Rows.Add(row);
        }

        private void DataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            int cell = 0;

            if (e.KeyCode == Keys.Enter)
            {
                int currentRow = dataGridView1.CurrentRow.Index;

                if (currentRow >= 0)
                {
                    //Получаем индекс столбца для данной ячейки
                    int currentcell = dataGridView1.CurrentCell.ColumnIndex;
                    //Получаем общее количество столбцов
                    int countcell = dataGridView1.ColumnCount;
                    cell = currentcell + 1;
                    //Если текущий столбец равен их общему количеству то делаем переход на новую строку

                    if (cell == countcell)
                    {
                        //Задаем первую ячейку, которая будет активной при переходе на новую строку
                        dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
                    }
                    else
                    {
                        //Задаем следующую ячейку в строке, которая будет активна при нажатии на клавишу Enter
                        dataGridView1.CurrentCell = dataGridView1.Rows[currentRow - 1].Cells[cell];
                    }
                }
            }
            base.OnKeyUp(e);
        }

        private void creatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
//            newMDIChild.MdiParent = this;
            newMDIChild.Show();

            
        }
    }
}