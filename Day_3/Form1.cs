using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Day_3
{
    public partial class Form1 : Form
    {
        public Graphics graphics;
        public Pen redPen;
        public Pen bluePen;
        public Pen blackPen;

        public float currentPosX = 10000f;
        public float currentPosY = 10000f;

        public string coordinatesFilePath = "../../coordinates.txt";

        public List<List<string>> wires;

        public List<List<Point2D>> points;

        public List<Point2D> crossingPoints;

        public const int BITMAP_MAX_X = 20000;
        public const int BITMAP_MAX_Y = 20000;

        public Point2D nearestPoint;
        public float manhattanDistance;





        public Form1()
        {
            InitializeComponent();

            redPen = new Pen(Color.Red);
            bluePen = new Pen(Color.Blue);
            blackPen = new Pen(Color.Black);

            wires = new List<List<string>>();

            points = new List<List<Point2D>>();
            points.Add(new List<Point2D>());
            points.Add(new List<Point2D>());

            crossingPoints = new List<Point2D>();

            nearestPoint = new Point2D(BITMAP_MAX_X, BITMAP_MAX_Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrepareDrawingField();
            LoadWiresCoords();
        }





        private void PrepareDrawingField()
        {
            pictureBox1.Image = new Bitmap(BITMAP_MAX_X, BITMAP_MAX_Y);

            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.White);
        }

        private void LoadWiresCoords()
        {
            StreamReader streamReader = new StreamReader(coordinatesFilePath);

            wires.Add(new List<string>());
            wires[0] = streamReader.ReadLine().Split(',').ToList();
            wires.Add(new List<string>());
            wires[1] = streamReader.ReadLine().Split(',').ToList();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            //labelStatus.Text = "PROCESSING";
            //labelStatusLight.BackColor = Color.Orange;

            DrawWires();
            GetCrossingPoints();
            MarkCrossingPointsOnImage();
            DefineTheNearestCrossingPoint();

            pictureBox1.Image.Save("../../result.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

            labelStatus.Text = "COMPLETED";
            labelStatusLight.BackColor = Color.LawnGreen;
        }

        private void DefineTheNearestCrossingPoint()
        {
            float snakeDistanceX;
            float snakeDistanceY;

            foreach (Point2D crossingPoint in crossingPoints)
            {
                snakeDistanceX = Math.Abs(currentPosX - crossingPoint.X);
                snakeDistanceY = Math.Abs(currentPosY - crossingPoint.Y);

                if(snakeDistanceX + snakeDistanceY < nearestPoint.X + nearestPoint.Y)
                {
                    nearestPoint.X = snakeDistanceX;
                    nearestPoint.Y = snakeDistanceY;
                }
            }
            manhattanDistance = nearestPoint.X + nearestPoint.Y;

            labelValueX.Text = nearestPoint.X.ToString();
            labelValueY.Text = nearestPoint.Y.ToString();
            labelValueDistance.Text = manhattanDistance.ToString();
        }

        private void MarkCrossingPointsOnImage()
        {
            for (int i = 0; i < crossingPoints.Count - 1; i++)
            {
                graphics.DrawLine
                    (
                        blackPen, 
                        crossingPoints[i].X, 
                        crossingPoints[i].Y, 
                        crossingPoints[i + 1].X, 
                        crossingPoints[i + 1].Y
                    );
            }
        }

        private void GetCrossingPoints()
        {
            foreach (Point2D pointWire1 in points[0])
            {
                foreach (Point2D pointWire2 in points[1])
                {
                    if(pointWire2.X == pointWire1.X && pointWire2.Y == pointWire1.Y)
                    {
                        crossingPoints.Add(new Point2D(pointWire2.X, pointWire2.Y));
                    }
                }
            }
        }

        private void DrawWires()
        {
            Pen pen;

            for (int i = 0; i <= wires.Count - 1; i++)
            {
                pen = (i == 0) ? bluePen : redPen;

                foreach (string point in wires[i])
                {
                    string direction = point.Substring(0, 1);
                    int numberOfSteps = int.Parse(point.Substring(1));

                    switch (direction)
                    {
                        case "U":
                            {
                                for (int j = 1; j <= numberOfSteps; j++)
                                {
                                    graphics.DrawLine(pen, currentPosX, currentPosY, currentPosX, currentPosY - j);
                                    points[i].Add(new Point2D(currentPosX, currentPosY - j));
                                }
                                currentPosY -= numberOfSteps;
                            }
                            break;
                        case "D":
                            {
                                for (int j = 1; j <= numberOfSteps; j++)
                                {
                                    graphics.DrawLine(pen, currentPosX, currentPosY, currentPosX, currentPosY + j);
                                    points[i].Add(new Point2D(currentPosX, currentPosY + j));
                                }
                                currentPosY += numberOfSteps;
                            }
                            break;
                        case "L":
                            {
                                for (int j = 1; j < numberOfSteps; j++)
                                {
                                    graphics.DrawLine(pen, currentPosX, currentPosY, currentPosX + j, currentPosY);
                                    points[i].Add(new Point2D(currentPosX + j, currentPosY));
                                }
                                currentPosX += numberOfSteps;
                            }
                            break;
                        case "R":
                            {
                                for (int j = 1; j < numberOfSteps; j++)
                                {
                                    graphics.DrawLine(pen, currentPosX, currentPosY, currentPosX - j, currentPosY);
                                    points[i].Add(new Point2D(currentPosX - j, currentPosY));
                                }
                                currentPosX -= numberOfSteps;
                            }
                            break;
                    }
                }

                currentPosX = 10000f;
                currentPosY = 10000f;

            }
        }

        public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return font.Size * ratio;
        }

        private void buttonDraw_Paint(object sender, PaintEventArgs e)
        {
            float fontSize = NewFontSize(e.Graphics, buttonDraw.Size, buttonDraw.Font, buttonDraw.Text);

            Font f = new Font("Consolas", fontSize / 2, FontStyle.Regular);
            buttonDraw.Font = f;
        }


    }
}
