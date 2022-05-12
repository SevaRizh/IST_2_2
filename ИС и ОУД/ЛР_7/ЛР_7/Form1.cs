using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ЛР_7
{
    public partial class Form1 : Form
    {
        Graphics g;         // холст pictureBox2
        Graphics g2;        // холст pictureBox3
        GraphicsPath pp;    // контур фантома-дырки
        SolidBrush br;      // кисть

        public Form1()
        {
            InitializeComponent();

            // для параплана
            g = Graphics.FromHwnd(pictureBox2.Handle);  // холст pictureBox2
            pp = paraplan(450, 130, 20);                // положение и размер фантома-дырки

            // для сплайнов и кривых Безье
            g2 = Graphics.FromHwnd(pictureBox3.Handle); // холст pictureBox3
            g2.SmoothingMode = SmoothingMode.AntiAlias; // сглаживание: enum SmoothingMode
        }

        /// <summary>
        /// Рисует корабль по нажатию на pictureBox1
        /// Вкладка "кораблик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Объявляем объект "g" класса Graphics и предоставляем
            // ему возможность рисования на pictureBox1:
            Graphics g = pictureBox1.CreateGraphics();

            g.Clear(Color.Turquoise);

            // Создаем объекты-кисти для закрашивания фигур
            SolidBrush myCorp = new SolidBrush(Color.DarkMagenta);
            SolidBrush myTrum = new SolidBrush(Color.DarkOrchid);
            SolidBrush myTrub = new SolidBrush(Color.DeepPink);
            SolidBrush mySeа = new SolidBrush(Color.Blue);
            //Выбираем перо myPen желтого цвета толщиной в 2 пикселя:
            Pen myWind = new Pen(Color.Yellow, 2);
            // Закрашиваем фигуры
            g.FillRectangle(myTrub, 300, 125, 75, 75);  // 1 труба (прямоугольник)
            g.FillRectangle(myTrub, 480, 125, 75, 75);  // 2 труба (прямоугольник)
            g.FillPolygon(myCorp, new Point[]           // корпус (трапеция)
                {
                new Point(100, 300),new Point(700, 300),
                new Point(700, 300),new Point(600, 400),
                new Point(600, 400),new Point(200, 400),
                new Point(200, 400),new Point(100, 300)
                }
            );
            g.FillRectangle(myTrum, 250, 200, 350, 100); // палуба(прямоугольник)
            
            // Море - 12 секторов-полуокружностей
            int x = 50;
            int Radius = 50;
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(mySeа, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
            
            // Иллюминаторы
            for (int y = 300; y <= 550; y += 50)
            {
                g.DrawEllipse(myWind, y, 240, 20, 20); // 6 окружностей
            }
        }

        /// <summary>
        /// Метод возвращает контур с центром в точке (x,y)
        /// и размером клетки r. Нарисуйте его на бумаге.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private GraphicsPath paraplan(int x, int y, int r)
        {
            int[,] pts = { { x - 4 * r, y },
                { x - 2 * r, y - r },
                { x + 2 * r, y - r },
                { x + 4 * r, y },
                { x + 3 * r, y + r },
                { x + r, y },
                { x - r, y },
                { x - 3 * r, y + r },
                { x - 4 * r, y }
            }; // параплан через массив pts
            
            Point[] pt = new Point[9]; // массив точек для gp
            
            byte[] typ = new byte[9]; // массив соединений
            
            for (int p = 0; p < 9; p++)
            {
                pt[p].X = pts[p, 0];
                pt[p].Y = pts[p, 1];
                typ[p] = (byte)PathPointType.Line;
                //ломаными,
                // PathPointType описан в System.Drawing.Drawing2D;
            };
            
            GraphicsPath gp = new GraphicsPath(pt, typ);
            
            return gp; // возвращаем внутренняя часть формы
        }

        /// <summary>
        /// Очищает экран по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" меню "Очистка экрана"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanScreen_Click(object sender, EventArgs e)
        {
            g2.Clear(BackColor);
        }

        /// <summary>
        /// Рисует незамкнутую ломаную по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Незамкнутая ломаная"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenBrokenLine_Click(object sender, EventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 2f);
            // Задание 10 точек, определяющих незамкнутую ломаную
            Point[] pm = star5(200, 200, 25);
            // Рисование незамкнутой ломаной из отрезков (Line)
            g2.DrawLines(redPen, pm); // для замыкания добавьте первую точку
        }

        /// <summary>
        /// Рисует замкнутую ломаную по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Замкнутая ломаная"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedBrokenLine_Click(object sender, EventArgs e)
        {
            Pen greenPen = new Pen(Color.Green, 2f);// Задание 10 точек, определяющих замкнутую область "звезда"
            Point[] pm = star5(250, 220, 25);
            // Рисование замкнутой ломаной из отрезков
            g2.DrawClosedCurve(greenPen, pm, 0f, FillMode.Winding);
            // Упругость: 0f - беск. физ. упругость - прямыми;
        }

        /// <summary>
        /// Рисует незамкнутый сплайн по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Незамкнутый сплайм"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JptnSpline_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(RandomColor(), 3f);
            // Задание точек, определяющих кривую
            Point[] pm = star5(400, 200, 25);
            float elasticity = Convert.ToSingle(textBox1.Text);
            // Рисование незамкнутой кривой через 10 точек сплайном
            g2.DrawCurve(pen, pm, elasticity);
        }

        /// <summary>
        /// Рисует замкнутый сплайн по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Замкнутый сплайм"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedSpline_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(RandomColor(), 2f);
            // Задание точек, определяющих кривую
            Point[] pm = star5(500, 200, 25);
            float elasticity = Convert.ToSingle(textBox1.Text); // - упругость
            
            // Рисование замкнутой кривой через 10 точек сплайном
            // g2.DrawClosedCurve(bluePen, pm, elasticity, FillMode.Alternate);
            
            // Упругость: 0f - беск.физ.упругость - прямыми;
            // 1f - отсутствие физ.упругости, наименьший суммарный изгиб
            // >1 - сдавленный берегами ручей, стремящийся увеличить изгиб своих излучин и течь по более длинному пути.
            g2.DrawClosedCurve(pen, pm, elasticity, FillMode.Alternate);
        }

        /// <summary>
        /// Рисует кривую Безье по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Одна кривая Безье"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneBezierCurve_Click(object sender, EventArgs e)
        {
            // кривая Безье: 4 точки (x,y) - старт,
            // управление1, управление2, end
            Point start = new Point(500, 100);
            Point control1 = new Point(500, 300);
            Point control2 = new Point(700, 300);
            Point finish = new Point(800, 100);
            
            g2.DrawBezier(new Pen(Color.Black, 3), start, control1, control2, finish); // это кривая Безье, дальше - для наглядности
            
            SolidBrush br = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Green, 1);
            g2.FillEllipse(br, start.X - 5, start.Y - 5, 11, 11);
            g2.FillEllipse(br, control1.X - 5, control1.Y - 5, 11, 11);
            g2.FillEllipse(br, control2.X - 5, control2.Y - 5, 11, 11);
            g2.FillEllipse(br, finish.X - 5, finish.Y - 5, 11, 11);
            g2.DrawLine(pen, start, control1);
            g2.DrawLine(pen, finish, control2);
        }

        /// <summary>
        /// Рисует незамкнутую кривую Безье по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Незамкнутая кривая Безье"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenBezierCurve_Click(object sender, EventArgs e)
        {
            // Зададим точки для 2-х кривых Безье - всего 7.
            Point start = new Point(500, 100);
            Point control1 = new Point(750, 50);
            Point control2 = new Point(510, 310);
            Point end1 = new Point(500, 300);
            Point control3 = new Point(490, 310);
            Point control4 = new Point(240, 50);
            Point end2 = new Point(490, 100);
            Point[] bezierPoints =
            {
                start, control1, control2, end1, 
                control3, control4, end2
            };
            
            // Рисуем
            g2.DrawBeziers(new Pen(RandomColor(), 3), bezierPoints);
        }

        /// <summary>
        /// Рисует замкнутую кривую Безье по нажатию на MenuStripItem
        /// Вкладка "Слаймы и кривые Безье" подменю "Замкнутая кривая Безье"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedBezierCurve_Click(object sender, EventArgs e)
        {
            // Зададим точки для 2-х кривых Безье - всего 7.
            Point start = new Point(600, 150);
            Point control1 = new Point(850, 100);
            Point control2 = new Point(610, 360);
            Point end1 = new Point(600, 350);
            Point control3 = new Point(590, 360);
            Point control4 = new Point(350, 100);
            Point end2 = start; // первая и третья точки совпадают
            Point[] bezierPoints =
            {
                start, control1, control2, end1, 
                control3, control4, end2
            };
            
            // Рисуем
            g2.DrawBeziers(new Pen(RandomColor(), 4), bezierPoints);
        }

        /// <summary>
        /// Открывает новое окно со своим примером векторной графики
        /// Вкладка "Кораблик" кнопка "Свой пример"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        /// <summary>
        /// По нажатию кнопки рисует изображение
        /// Вкладка "Параплан" кнопка "Нарисуй"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDraw_Click(object sender, EventArgs e)
        {
            GraphicsPath pp1 = paraplan(150, 80, 30); // Рисуем параплан меньшего размера
            Pen pen = new Pen(RandomColor(), 4f);
            g.DrawPath(pen, pp1);
        }

        /// <summary>
        /// По нажатию кнопки разукрашивает изображение
        /// Вкладка "Параплан" кнопка "Закрась"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaint_Click(object sender, EventArgs e)
        {
            g.ResetClip(); // сбрасывает вырезанную область и делает ее бесконечной, анти_ExcludeClip();
            br = new SolidBrush(RandomColor());
            g.FillPath(br, pp); // ставим заплатку
        }

        /// <summary>
        /// Рисует параплан по нажатию на pictureBox2
        /// Вкладка "параплан"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            // Метод обновляет отсеченную область gp
            Region gp = new Region(pp);
            g.ExcludeClip(gp);

            // Рисуем параплан большего размера
            GraphicsPath pp1 = paraplan(450, 180, 80);  // контур
            br = new SolidBrush(RandomColor());         // кисть
            g.FillPath(br, pp1);                        // закраска
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

        /// <summary>
        /// Возвращает массив 10 точек "Звезды"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private Point[] star5(int x, int y, int r)
        {
            // объявлениz былb упрощенs с Point point1 = new Point(x, y - 6 * r);
            Point point1 = new(x, y - 6 * r);
            Point point2 = new(x + 2 * r, y - 3 * r);
            Point point3 = new(x + 6 * r, y - 2 * r);
            Point point4 = new(x + 3 * r, y + r);
            Point point5 = new(x + 4 * r, y + 5 * r);
            Point point6 = new(x, y + 3 * r);
            Point point7 = new(x - 4 * r, y + 5 * r);
            Point point8 = new(x - 3 * r, y + r);
            Point point9 = new(x - 6 * r, y - 2 * r);
            Point point10 = new(x - 2 * r, y - 3 * r);
            Point[] pm =
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7,
                point8,
                point9,
                point10
            };
            return pm;
        }

        /// <summary>
        /// Открывает новое окно со своим примером
        /// Вкладка "Параплан" кнопка "Свой пример"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExamp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}