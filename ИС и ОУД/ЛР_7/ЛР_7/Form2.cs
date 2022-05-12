using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_7
{
    public partial class Form2 : Form
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public Form2()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            // Объявляем объект "g" класса Graphics и предоставляем
            // ему возможность рисования на pictureBox1:
            Graphics g = pictureBox1.CreateGraphics();

            g.Clear(Color.LightSlateGray);

            // Задаем цвета для использования с методом Random()
            Color[] clr = { Color.LavenderBlush, Color.RosyBrown, 
                Color.MediumTurquoise, Color.Bisque, Color.Beige, 
                Color.Linen, Color.Cornsilk, Color.Coral, Color.Orchid,
                Color.Honeydew, Color.SkyBlue, Color.YellowGreen };

            // Цвет чаши для мороженного прозрачность 150 из 250 (где 250 - полностью не прозрачная)
            SolidBrush myGlass = new SolidBrush(Color.FromArgb(150, Color.LightGoldenrodYellow));
            
            // Рандомные цвета для шариков, можно сделать неповторяющимися, но пока будут как есть
            SolidBrush myIceCream1 = new SolidBrush(clr[rnd.Next(clr.Length)]);
            SolidBrush myIceCream2 = new SolidBrush(clr[rnd.Next(clr.Length)]);
            SolidBrush myIceCream3 = new SolidBrush(clr[rnd.Next(clr.Length)]);
            
            // Цвет ложки
            SolidBrush mySpoon = new SolidBrush(Color.LightSkyBlue);

            // Рисуем ложку
            g.FillPolygon(mySpoon, new Point[]
                {
                    new Point(455, 345),
                    new Point(850, 57),
                    new Point(835, 57),
                    new Point(445, 340)
                }
            );

            // Рисуем шарики мороженного
            g.FillEllipse(myIceCream1, 370, 40, 180, 180);
            g.FillEllipse(myIceCream2, 410, 110, 180, 180);
            g.FillEllipse(myIceCream3, 310, 110, 180, 180);

            // Рисуем чашу для мороженого, поверх всех остальных объектов, с прозрачностью
            g.FillPolygon(myGlass, new Point[]
                {
                    new Point(200, 175), //new Point(700, 250),
                    new Point(700, 175), //new Point(460, 350),
                    new Point(460, 350), //new Point(460, 425),
                    new Point(460, 425), //new Point(480, 430),
                    new Point(500, 450), //new Point(420, 430),
                    new Point(400, 450), //new Point(440, 425),
                    new Point(440, 425), //new Point(440, 350),
                    new Point(440, 350)//, new Point(200, 250),
                }
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form_Load(sender, e);
        }
    }
}
