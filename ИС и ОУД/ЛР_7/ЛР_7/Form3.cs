using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_7
{
    public partial class Form3 : Form
    {
        Graphics g;         // холст pictureBox1
        GraphicsPath pp;    // контур фантома-дырки
        SolidBrush br;      // кисть

        public Form3()
        {
            InitializeComponent();

            g = Graphics.FromHwnd(pictureBox1.Handle);  // холст pictureBox2
            pp = example(450, 190, 5);                // положение и размер фантома-дырки
            br = new SolidBrush(Color.Green);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            GraphicsPath fg = example(150, 90, 8); // Рисуем фигуру меньшего размера
            Pen pen = new Pen(RandomColor(), 4f);
            g.DrawPath(pen, fg);
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            g.ResetClip(); // сбрасывает вырезанную область и делает ее бесконечной, анти_ExcludeClip();
            br = new SolidBrush(RandomColor());
            g.FillPath(br, pp); // ставим заплатку
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Метод обновляет отсеченную область gp
            Region gp = new Region(pp);
            g.ExcludeClip(gp);

            // Рисуем фигуру большего размера
            GraphicsPath pp1 = example(450, 200, 20);  // контур
            br = new SolidBrush(RandomColor());         // кисть
            g.FillPath(br, pp1);                        // закраска
        }

        /// <summary>
        /// Метод возвращает контур с центром в точке (x,y)
        /// и размером клетки r.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private GraphicsPath example(int x, int y, int r)
        {
            int buff = 13;

            int[,] pts = { { x, y - 4 * r },    // 1 точка
                { x + r, y - 2 * r },           // 2
                { x + 10 * r, y - 8 * r },      // 3
                { x + 5 * r, y },               // 4
                { x + 8 * r, y + 8 * r },       // 5
                { x + r, y + 2 * r },           // 6
                { x, y + 6 * r },               // 7
                { x - r, y + 2 * r },           // 8
                { x - 8 * r, y + 8 * r },       // 9
                { x - 5 * r, y },               // 10
                { x - 10 * r, y - 8 * r },      // 11
                { x - r, y - 2 * r },           // 12
                { x, y - 4 * r }                // 13 вернулись в начало
            }; // фигура через массив pts

            Point[] pt = new Point[buff]; // массив точек для gp

            byte[] typ = new byte[buff]; // массив соединений

            for (int p = 0; p < buff; p++)
            {
                pt[p].X = pts[p, 0];
                pt[p].Y = pts[p, 1];
                typ[p] = (byte)PathPointType.Line;
            };

            GraphicsPath gp = new GraphicsPath(pt, typ);

            return gp;
        }

        /// <summary>
        /// Возвращает случайный цвет r, g, b
        /// </summary>
        /// <returns></returns>
        public Color RandomColor()
        {
            int r, g, b;
            byte[] bytes1 = new byte[3];    // массив 3 цветов
            Random rnd1 = new Random();     // объект класса
            rnd1.NextBytes(bytes1);         // генерация массива
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b); // цвет через метод
        }
    }
}
