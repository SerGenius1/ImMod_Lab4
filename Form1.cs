using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int rows, cols, scale, param1, param2, param3, speedRate;
        double initialPopulation;

        bool[,] map;

        Bitmap bitmap;
        Graphics graphics;
        Random random = new Random();
        Brush brush = new SolidBrush(Color.Crimson);

        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else
                StartGame();
        }

        private void InitializeConstants()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            param1 = (int)inputParam1.Value;
            param2 = (int)inputParam2.Value;
            param3 = (int)inputParam3.Value;
            initialPopulation = (double)inputParam4.Value;
            scale = (int)inputScale.Value;
            speedRate = (int)inputSpeed.Value;
            timer1.Interval = 1000 / speedRate;   //Скорость срабатывания таймера 

            //Рассчет размера игрового поля
            rows = pictureBox1.Height / scale;
            cols = pictureBox1.Width / scale;
            map = new bool[cols, rows];

        }

        private void StartGame()
        {
            InitializeConstants();

            CreateMap();
            ShowMap();

            timer1.Start();
        }

        private void CreateMap()
        {
            for (int x = 0; x < cols; x++)
            {
                map[x, 0] = false;
                map[x, rows - 1] = false;
            }
            for (int y = 0; y < rows; y++)
            {
                map[0, y] = false;
                map[cols - 1, y] = false;
            }

            for (int x = 1; x < cols - 1; x++)
                for (int y = 1; y < rows - 1; y++)
                    if (random.NextDouble() < initialPopulation)
                        map[x, y] = true;
                    else
                        map[x, y] = false;
        }

        private void ShowMap()
        {
            graphics.Clear(Color.Black);

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    if (map[x, y])
                        graphics.FillRectangle(brush, x * scale, y*scale, scale, scale);

            pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CalculateNextGeneration();
            ShowMap();
        }

        private void CalculateNextGeneration()
        {
            bool[,] tempGeneration = new bool[cols, rows];
            int numOfNeighbours;
            for (int x = 1; x < cols - 1; x++)
            {
                for (int y = 1; y < rows - 1; y++)
                {
                    numOfNeighbours = GetNumberOfNeighbours(x, y);          //Сколько соседей у данной клетки?
                    bool hasLife = map[x, y];
                    //Клетка жива:
                    if (hasLife)
                    {
                        if (numOfNeighbours >= param1 && numOfNeighbours <= param2)
                            tempGeneration[x, y] = true;
                        else
                            tempGeneration[x, y] = false;
                    }
                    if (!hasLife)
                    {
                        if (numOfNeighbours == param3)
                            tempGeneration[x, y] = true;
                        else
                            tempGeneration[x, y] = false;
                    }
                }
            }

            map = tempGeneration;
        }

        private int GetNumberOfNeighbours(int posx, int posy)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    var selfCheck = (i == 0 && j == 0);
                    if (map[posx + i, posy + j] && !selfCheck)
                        count++;
                }
            }
            return count;
        }
    }
}