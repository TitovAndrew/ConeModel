using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGLaba5
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        //Радиусы 
        double R = 0;
        double R1 = 80;
        double R2 = 120;
        //double L = 2;
        //Постоянная смещения X
        readonly static int sdvigX = 238;
        //Постоянная смещения Y
        readonly static int sdvigY = 163;
        //Верхняя и нижняя окружность
        readonly static int df = 2;
        //Разбиение на части боковины
        readonly static int d0 = 36;
        //Точки, представляющие усеченный конус
        Point3D[,] WorldObjectPoints = new Point3D[d0 + 1, 2];
        //Коэфициент маштабирования
        double f = 1;
        //Полигоны и их Z средняя
        Polygons[] arrayOfPolygons = new Polygons[121];
        //PointF[] points = new PointF[24]; // полигон верхней окружности
        //PointF[] points2 = new PointF[24]; // полигон нижней окружности
        //List<PointF[]> sidePolygonsList = new List<PointF[]>(); // список боковых полигонов
        public Form1()
        {
            InitializeComponent();
            InitWorldObjectPoints();
            Pravka(); //это смещение
            /*GoSystem(sdvigX, sdvigY, 0);
            PovorotX(30);
            PovorotY(30);
            Peremeshenie(50, 70, 0);
            PovorotZ(180);
            Mashtab(0.50f);
            Mashtab(7);
            GoSystem(-sdvigX, -sdvigY, 0);*/
            ShowPicture();
        }
        /// <summary>
        /// Метод нахождения ключевых точек полигональной мадели
        /// </summary>
        public void InitWorldObjectPoints()
        {
            double x, y, z;
            double angle = 0;
            for (int L = 0; L<= 1; L++)
            {
                R = R1 + (R2 - R1) * (L - 0.5);
                for (int i = 0; i < d0; i++)
                {
                    angle = 2 * Math.PI * (i + 1) / d0;
                    x = R * Math.Sin(angle);
                    y = R * Math.Cos(angle);
                    if (L == 0)
                    {
                        z = 50;
                    }
                    else
                    {
                        z = -50;
                    }
                    WorldObjectPoints[i, L] = new Point3D(x, y, z);
                }
            }
            WorldObjectPoints[36, 0] = new Point3D(0, 0, 50);//центр верхней
            WorldObjectPoints[36, 1] = new Point3D(0, 0, -50);//центр нижней
        }
        /// <summary>
        /// Метод, смещающий объект в центр проэцирующей плоскости
        /// </summary>
        public void Pravka()
        {
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    WorldObjectPoints[i, j].X += sdvigX;
                    WorldObjectPoints[i, j].Y += sdvigY;
                }
            }
        }
        /// <summary>
        /// Метод вывода проэкции объёмного тела, в текущем положении по координатам(ортогональное проэцирование)
        /// </summary>
        public void ShowPicture()
        {
            double z0, z0up, z0down, countUp, countDown; //z1, z2, z3, z4;
            pictureBox1.BackColor = Color.DimGray;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Pen pen = new Pen(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            double[] z01 = new double[d0];//массив значений z точек верхней окружности
            double[] z02 = new double[d0];//массив значений z точек нижней окружности
            //PointF[] pointsUp = new PointF[d0]; // полигон верхней окружности
            //PointF[] pointsDown = new PointF[d0]; // полигон нижней окружности        
            Graphics graph = Graphics.FromImage(bmp);
            PointF pointCenterUp = new PointF(WorldObjectPoints[36, 0].X, WorldObjectPoints[36, 0].Y);
            PointF pointCenterDown = new PointF(WorldObjectPoints[36, 1].X, WorldObjectPoints[36, 1].Y);

            for (int i = 0; i <= d0 - 1; i++)
            {                
                //pointsUp[i] = new PointF(WorldObjectPoints[i, 0].X, WorldObjectPoints[i, 0].Y);
                //pointsDown[i] = new PointF(WorldObjectPoints[i, 1].X, WorldObjectPoints[i, 1].Y);
                z01[i] = WorldObjectPoints[i, 0].Z;
                z02[i] = WorldObjectPoints[i, 1].Z;
                PointF point1 = new PointF(WorldObjectPoints[i, 0].X, WorldObjectPoints[i, 0].Y);                
                PointF point2 = new PointF(WorldObjectPoints[i, 1].X, WorldObjectPoints[i, 1].Y);
                
                if (i != 35)
                {
                    PointF point3 = new PointF(WorldObjectPoints[i + 1, 1].X, WorldObjectPoints[i + 1, 1].Y);
                    PointF point4 = new PointF(WorldObjectPoints[i + 1, 0].X, WorldObjectPoints[i + 1, 0].Y);
                    PointF[] allPoints = { point1, point2, point3, point4 };
                    z0 = (WorldObjectPoints[i, 0].Z + WorldObjectPoints[i, 1].Z + WorldObjectPoints[i + 1, 1].Z + WorldObjectPoints[i + 1, 0].Z) / 4;
                    arrayOfPolygons[i] = new Polygons(z0, allPoints);
                    PointF[] upPoints = { point1, point4, pointCenterUp };
                    z0up = (WorldObjectPoints[36, 0].Z + WorldObjectPoints[i, 0].Z + WorldObjectPoints[i + 1, 0].Z) / 3;
                    arrayOfPolygons[i + 36] = new Polygons(z0up, upPoints);
                    PointF[] downPoints = { point2, point3, pointCenterDown };
                    z0down = (WorldObjectPoints[36, 1].Z + WorldObjectPoints[i, 1].Z + WorldObjectPoints[i + 1, 1].Z) / 3;
                    arrayOfPolygons[i + 72] = new Polygons(z0down, downPoints);
                }
                else
                {
                    PointF point3 = new PointF(WorldObjectPoints[0, 1].X, WorldObjectPoints[0, 1].Y);
                    PointF point4 = new PointF(WorldObjectPoints[0, 0].X, WorldObjectPoints[0, 0].Y);
                    PointF[] allPoints = { point1, point2, point3, point4 };
                    z0 = (WorldObjectPoints[i, 0].Z + WorldObjectPoints[i, 1].Z + WorldObjectPoints[0, 1].Z + WorldObjectPoints[0, 0].Z) / 4;
                    arrayOfPolygons[i] = new Polygons(z0, allPoints);
                    PointF[] upPoints = { point1, point4, pointCenterUp };
                    z0up = (WorldObjectPoints[36, 0].Z + WorldObjectPoints[i, 0].Z + WorldObjectPoints[0, 0].Z) / 3;
                    arrayOfPolygons[i + 36] = new Polygons(z0up, upPoints);
                    PointF[] downPoints = { point2, point3, pointCenterDown };
                    z0down = (WorldObjectPoints[36, 1].Z + WorldObjectPoints[i, 1].Z + WorldObjectPoints[0, 1].Z) / 3;
                    arrayOfPolygons[i + 72] = new Polygons(z0down, downPoints);
                }
            }

            //countUp = 0;
            //countDown = 0;

            //for (int i = 0; i < d0; i++)
            //{
            //    countUp += z01[i];
            //    countDown += z02[i];
            //}

            //Добавляем нижнию и верхнюю окружности к остальным полигонам
            //arrayOfPolygons[36] = new Polygons(countDown / d0, pointsDown);
            //arrayOfPolygons[37] = new Polygons(countUp / d0, pointsUp);

            for (int m = 0; m < 107; m++)
            {
                for (int i = 0; i < 107; i++)
                {
                    if (arrayOfPolygons[i].Z0 > arrayOfPolygons[i + 1].Z0)
                    {
                        arrayOfPolygons[120] = arrayOfPolygons[i];
                        arrayOfPolygons[i] = arrayOfPolygons[i + 1];
                        arrayOfPolygons[i + 1] = arrayOfPolygons[120];
                    }
                }
            }

            for (int i = 0; i <= 107; i++)
            {
                graph.FillPolygon(yellowBrush, arrayOfPolygons[i].Plgn);
                graph.DrawPolygon(pen, arrayOfPolygons[i].Plgn);
            }
            pictureBox1.Image = bmp;
        }
        /// <summary>
        /// Метод, смещающий систему координат
        /// </summary>
        /// <param name="dx">параметр смещения системы по оси x</param>
        /// <param name="dy">параметр смещения системы по оси y</param>
        /// <param name="dz">параметр смещения системы по оси z</param>
        public void GoSystem(int dx, int dy, int dz)
        {
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    WorldObjectPoints[i, j].X = WorldObjectPoints[i, j].X - dx;
                    WorldObjectPoints[i, j].Y = WorldObjectPoints[i, j].Y - dy;
                    WorldObjectPoints[i, j].Z = WorldObjectPoints[i, j].Z - dz;
                }
            }
        }
        /// <summary>
        /// Метод поворота объекта вдокруг оси x
        /// </summary>
        /// <param name="a">Угол поворота</param>
        public void PovorotX(int a)
        {
            double sina = Math.Sin(a * Math.PI / 180);
            double cosa = Math.Cos(a * Math.PI / 180);
            float y, z;
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    y = WorldObjectPoints[i, j].Y;
                    z = WorldObjectPoints[i, j].Z;
                    WorldObjectPoints[i, j].Y = (float)(y * cosa - z * sina);
                    WorldObjectPoints[i, j].Z = (float)(y * sina + z * cosa);
                }
            }
        }
        /// <summary>
        /// Метод поворота объекта вдокруг оси y
        /// </summary>
        /// <param name="a">Угол поворота</param>
        public void PovorotY(int b)
        {
            double sinb = Math.Sin(b * Math.PI / 180);
            double cosb = Math.Cos(b * Math.PI / 180);
            float x, z;
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    x = WorldObjectPoints[i, j].X;
                    z = WorldObjectPoints[i, j].Z;
                    WorldObjectPoints[i, j].X = (float)(x * cosb + z * sinb);
                    WorldObjectPoints[i, j].Z = (float)(-x * sinb + z * cosb);
                }
            }
        }
        /// <summary>
        /// Метод поворота объекта вдокруг оси z
        /// </summary>
        /// <param name="a">Угол поворота</param>
        public void PovorotZ(int u)
        {
            double siny = Math.Sin(u * Math.PI / 180);
            double cosy = Math.Cos(u * Math.PI / 180);
            float x, y;
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    x = WorldObjectPoints[i, j].X;
                    y = WorldObjectPoints[i, j].Y;
                    WorldObjectPoints[i, j].X = (float)(x * cosy - y * siny);
                    WorldObjectPoints[i, j].Y = (float)(x * siny + y * cosy);
                }
            }
        }
        /// <summary>
        /// Метод, смещающий объект вдоль осей на соответственные значения.
        /// </summary>
        /// <param name="dx">Значение для x</param>
        /// <param name="dy">Значение для y</param>
        /// <param name="dz">Значение для z</param>
        public void Peremeshenie(int dx, int dy, int dz)
        {
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    WorldObjectPoints[i, j].X += dx;
                    WorldObjectPoints[i, j].Y += dy;
                    WorldObjectPoints[i, j].Z += dz;
                }
            }
        }
        /// <summary>
        /// Метод маштабирования объекта
        /// </summary>
        /// <param name="k">Коэфициент маштабирования</param>
        public void Mashtab(double k)
        {
            for (int i = 0; i <= d0; i++)
            {
                for (int j = 0; j < df; j++)
                {
                    WorldObjectPoints[i, j].X = (float)(WorldObjectPoints[i, j].X * k);
                    WorldObjectPoints[i, j].Y = (float)(WorldObjectPoints[i, j].Y * k);
                    WorldObjectPoints[i, j].Z = (float)(WorldObjectPoints[i, j].Z * k);
                }
            }
        }

        private void BTpov_Click(object sender, EventArgs e)
        {
            int ax = 0;
            try
            {
                ax = int.Parse(TBax.Text);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение.");
                TBax.Clear();
                TBax.Focus();
            }
            int by = 0;
            try
            {
                by = int.Parse(TBby.Text);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение.");
                TBby.Clear();
                TBby.Focus();
            }
            int uz = 0;
            try
            {
                uz = int.Parse(TBuz.Text);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение.");
                TBuz.Clear();
                TBuz.Focus();
            }
            GoSystem(sdvigX, sdvigY, 0);
            PovorotX(ax);
            PovorotY(by);
            PovorotZ(uz);
            GoSystem(-sdvigX, -sdvigY, 0);
            ShowPicture();
        }

        private void BTsmesh_Click(object sender, EventArgs e)
        {
            int dx = 0;
            try
            {
                dx = int.Parse(TBdx.Text);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение.");
                TBdx.Clear();
                TBdx.Focus();
            }
            int dy = 0;
            try
            {
                dy = int.Parse(TBdy.Text);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение.");
                TBdy.Clear();
                TBdy.Focus();
            }
            GoSystem(sdvigX, sdvigY, 0);
            Peremeshenie(dx, dy, 0);
            GoSystem(-sdvigX, -sdvigY, 0);
            ShowPicture();
        }

        private void TBmash_Click(object sender, EventArgs e)
        {
            double k = 0;
            try
            {
                k = double.Parse(TBkoef.Text);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение.");
                TBkoef.Clear();
                TBkoef.Focus();
            }
            if (k != 0)
            {
                GoSystem(sdvigX, sdvigY, 0);
                Mashtab(k / f);
                GoSystem(-sdvigX, -sdvigY, 0);
                ShowPicture();
                f = k;
            }
        }

        private void BTDefolt_Click(object sender, EventArgs e)
        {
            InitWorldObjectPoints();
            Pravka();
            ShowPicture();
            f = 1;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу написал: Титов Андрей 6315");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }
    }
}
