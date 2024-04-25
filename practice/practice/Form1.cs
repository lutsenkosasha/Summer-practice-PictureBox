using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice
{

    public partial class Form1 : Form
    {
        private List<ImageInfo> imageList = new List<ImageInfo>();
        private Image defaultImage;
        private Color chosenColor = Color.Green;
        private SoundPlayer soundPlayer;

        private string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        private Dictionary<string, List<Point>> circleCoordinates = new Dictionary<string, List<Point>>()
        {
            { "Январь", new List<Point>() },
            { "Февраль", new List<Point>() },
            { "Март", new List<Point>() },
            { "Апрель", new List<Point>() },
            { "Май", new List<Point>() },
            { "Июнь", new List<Point>() },
            { "Июль", new List<Point>() },
            { "Август", new List<Point>() },
            { "Сентябрь", new List<Point>() },
            { "Октябрь", new List<Point>() },
            { "Ноябрь", new List<Point>() },
            { "Декабрь", new List<Point>() }
        };

        // Класс для хранения информации о каждом изображении
        public class ImageInfo
        {
            public Image Image { get; set; }
            public Point Position { get; set; }
            public Size Size { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            trackBar.Minimum = 0;
            trackBar.Maximum = months.Length - 1;
            trackBar.ValueChanged += TrackBar_ValueChanged;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.Paint += PictureBox_Paint;

            // Загрузка изображения плода
            defaultImage = Image.FromFile("C:\\Users\\26862\\OneDrive\\Рабочий стол\\2kurs_2sem\\C#\\practice\\practice\\fig_fruit.png");

            // Установка начального значения месяца
            labelMonth.Text = months[trackBar.Value];

            // Подключение звука
            soundPlayer = new SoundPlayer("C:\\Users\\26862\\OneDrive\\Рабочий стол\\2kurs_2sem\\C#\\practice\\practice\\schelchok-na-tsifrovom-fotoapparate.wav");

            // Инициализация зеленых кругов
            InitializeGreenCircles();
        }

        private void InitializeGreenCircles()
        {
            circleCoordinates["Февраль"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(480, 310),
                new Point(300, 100),
                new Point(440, 120)
            });

            circleCoordinates["Март"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(480, 310),
                new Point(260, 140),
                new Point(450, 120),
                new Point(200, 250),
                new Point(280, 180)
            });

            circleCoordinates["Апрель"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(300, 400),
                new Point(210, 180),
                new Point(450, 120),
                new Point(300, 250),
                new Point(280, 180),
                new Point(600, 200),
                new Point(260, 140),
                new Point(450, 120),
                new Point(400, 250)
            });

            circleCoordinates["Май"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(300, 400),
                new Point(210, 180),
                new Point(410, 120),
                new Point(250, 250),
                new Point(280, 180),
                new Point(620, 200),
                new Point(200, 120),
                new Point(450, 120),
                new Point(470, 200),
                new Point(600, 200),
                new Point(300, 150),
                new Point(450, 120),
                new Point(300, 150)
            });

            circleCoordinates["Июнь"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(370, 200),
                new Point(210, 180),
                new Point(450, 190),
                new Point(250, 250),
                new Point(280, 180),
                new Point(520, 130),
                new Point(200, 120),
                new Point(450, 120),
                new Point(520, 220),
                new Point(600, 200),
                new Point(310, 200),
                new Point(450, 120),
                new Point(250, 100),
                new Point(350, 270),
                new Point(270, 350),
                new Point(210, 180),
                new Point(490, 170),
                new Point(450, 120),
                new Point(580, 100),
                new Point(570, 270),
                new Point(390, 250),
                new Point(400, 100),
                new Point(330, 100)
            });

            circleCoordinates["Июль"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(310, 200),
                new Point(210, 180),
                new Point(490, 190),
                new Point(250, 250),
                new Point(280, 180),
                new Point(520, 130),
                new Point(200, 120),
                new Point(450, 120),
                new Point(520, 220),
                new Point(610, 240),
                new Point(410, 200),
                new Point(450, 120),
                new Point(280, 100),
                new Point(350, 270),
                new Point(270, 350),
                new Point(210, 180),
                new Point(490, 170),
                new Point(450, 300),
                new Point(580, 100),
                new Point(570, 270),
                new Point(390, 250),
                new Point(400, 100),
                new Point(330, 100),
                new Point(350, 350),
                new Point(320, 200),
                new Point(210, 180),
                new Point(450, 190),
                new Point(250, 250),
                new Point(300, 180),
                new Point(480, 130),
                new Point(210, 120),
                new Point(350, 90),
                new Point(520, 90),
                new Point(540, 90),
                new Point(200, 160),
                new Point(250, 300),
                new Point(600, 120),
                new Point(550, 300),
                new Point(400, 250),
                new Point(300, 70)
            });

            circleCoordinates["Август"].AddRange(new List<Point>()
            {
                new Point(350, 270),
                new Point(310, 200),
                new Point(210, 180),
                new Point(490, 190),
                new Point(250, 250),
                new Point(280, 180),
                new Point(520, 130),
                new Point(200, 120),
                new Point(450, 120),
                new Point(520, 220),
                new Point(610, 240),
                new Point(410, 200),
                new Point(450, 120),
                new Point(280, 100),
                new Point(350, 270),
                new Point(270, 350),
                new Point(210, 180),
                new Point(490, 170),
                new Point(450, 300),
                new Point(580, 100),
                new Point(570, 270),
                new Point(390, 250),
                new Point(400, 100),
                new Point(330, 100),
                new Point(350, 350),
                new Point(320, 200),
                new Point(210, 180),
                new Point(450, 190),
                new Point(250, 250),
                new Point(300, 180),
                new Point(480, 130),
                new Point(210, 120),
                new Point(350, 90),
                new Point(520, 90),
                new Point(540, 90),
                new Point(200, 160),
                new Point(250, 300),
                new Point(600, 120),
                new Point(550, 300),
                new Point(400, 250),
                new Point(300, 70),
                new Point(350, 400),
                new Point(400, 400),
                new Point(470, 370),
                new Point(250, 65),
                new Point(300, 75),
                new Point(350, 340),
                new Point(400, 330),
                new Point(200, 300),
                new Point(330, 70),
                new Point(400, 70),
                new Point(450, 70)
            });

            circleCoordinates["Сентябрь"].AddRange(new List<Point>()
            {
                new Point(310, 200),
                new Point(210, 180),
                new Point(490, 190),
                new Point(280, 180),
                new Point(520, 130),
                new Point(450, 120),
                new Point(520, 220),
                new Point(610, 240),
                new Point(410, 200),
                new Point(450, 120),
                new Point(280, 100),
                new Point(490, 170),
                new Point(450, 300),
                new Point(570, 270),
                new Point(390, 250),
                new Point(400, 100),
                new Point(330, 100),
                new Point(320, 200),
                new Point(210, 180),
                new Point(450, 190),
                new Point(250, 250),
                new Point(300, 180),
                new Point(480, 130),
                new Point(210, 120),
                new Point(350, 90),
                new Point(200, 160),
                new Point(250, 300),
                new Point(400, 250),
                new Point(300, 70),
                new Point(350, 400),
                new Point(470, 370),
                new Point(300, 75),
                new Point(350, 340),
                new Point(200, 300),
                new Point(450, 70)
            });

            circleCoordinates["Октябрь"].AddRange(new List<Point>()
            {
                new Point(310, 200),
                new Point(520, 130),
                new Point(450, 120),
                new Point(520, 220),
                new Point(410, 200),
                new Point(390, 250),
                new Point(400, 100),
                new Point(330, 100),
                new Point(320, 200),
                new Point(450, 190),
                new Point(250, 250),
                new Point(480, 130),
                new Point(210, 120),
                new Point(400, 250),
                new Point(300, 70),
                new Point(470, 370),
                new Point(350, 340),
                new Point(450, 70)
            });

            circleCoordinates["Ноябрь"].AddRange(new List<Point>()
            {
                new Point(310, 200),
                new Point(410, 200),
                new Point(250, 250),
                new Point(400, 250),
                new Point(300, 70),
                new Point(470, 370),
                new Point(450, 70)
            });
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.SaddleBrown, 3);
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.FillRectangle(brush, 0, 500, 800, 800);            // Земля

            // Стволы и ветви

            graphics.DrawLine(pen, 400, 500, 500, 300);
            graphics.DrawLine(pen, 500, 300, 470, 180);
            graphics.DrawLine(pen, 500, 300, 650, 220);
            graphics.DrawLine(pen, 650, 220, 670, 170);

            graphics.DrawLine(pen, 390, 500, 440, 60);
            graphics.DrawLine(pen, 432, 130, 490, 50);
            graphics.DrawLine(pen, 412, 300, 350, 100);

            graphics.DrawLine(pen, 380, 500, 360, 250);
            graphics.DrawLine(pen, 360, 250, 310, 70);
            graphics.DrawLine(pen, 340, 180, 230, 60);

            graphics.DrawLine(pen, 370, 500, 290, 300);
            graphics.DrawLine(pen, 321, 380, 330, 330);
            graphics.DrawLine(pen, 352, 460, 310, 400);

            graphics.DrawLine(pen, 340, 500, 240, 250);
            graphics.DrawLine(pen, 255, 290, 270, 200);
            graphics.DrawLine(pen, 260, 300, 150, 180);

            // Создание кроны дерева

            string currentMonth = months[trackBar.Value];
            foreach (Point position in circleCoordinates[currentMonth])
            {
                graphics.FillEllipse(new SolidBrush(chosenColor), position.X - 30, position.Y - 30, 80, 80);
            }

            // Цветение дерева

            Random random = new Random();
            if (currentMonth == "Июнь")
            {
                Bitmap result = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = e.Graphics;
                Image img = Image.FromFile("C:\\Users\\26862\\OneDrive\\Рабочий стол\\2kurs_2sem\\C#\\practice\\practice\\icon_flower.png");

                int x1 = 200;       // Координата X верхнего левого угла области
                int y1 = 180;       // Координата Y верхнего левого угла области
                int w = 340;        // Ширина области
                int h = 230;        // Высота области

                for (int i = 0; i < 5; i++)
                {
                    int centerX = random.Next(x1, x1 + w);          // Случайная координата X центра круга внутри области
                    int centerY = random.Next(y1, y1 + h);          // Случайная координата Y центра круга внутри области
                    int r = 60;
                    g.DrawImage(img, centerX - r, centerY - r, img.Width / 20, img.Height / 20);
                }
            }

            // Появление плодов

            if (currentMonth == "Июль" || currentMonth == "Август")
            {
                foreach (ImageInfo imageInfo in imageList)
                {
                    e.Graphics.DrawImage(imageInfo.Image, new Rectangle(imageInfo.Position, imageInfo.Size));
                }
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            string currentMonth = months[trackBar.Value];
            if (e.Button == MouseButtons.Left)
            {
                // Проверяем, что клик был внутри области pictureBox и текущий месяц - июль или август
                if (pictureBox.ClientRectangle.Contains(e.Location) && (currentMonth == "Июль" || currentMonth == "Август"))
                {
                    ImageInfo imageInfo = new ImageInfo();
                    imageInfo.Image = defaultImage;
                    imageInfo.Position = e.Location;
                    imageInfo.Size = new Size(30, 30);

                    imageList.Add(imageInfo);
                    pictureBox.Refresh();
                }
            }
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            int index = trackBar.Value;
            labelMonth.Text = months[index];
            pictureBox.Refresh();

            // Воспроизведение звука
            soundPlayer.Play();
        }

        private void btnChooseColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chosenColor = colorDialog.Color;
                pictureBox.Invalidate();             // Перерисовываем только pictureBox
            }
        }
    }
}