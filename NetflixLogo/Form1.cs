using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixLogo
{
    public partial class Form1 : Form
    {

        Graphics graphics = null;
        private int centralHorizontalLine;
        private int centralVerticalLine;
        private int horizontalDistance = 50;//distância entre as barras verticais
        private int verticalDistance = 150;//alongar
        private int circleSize = 512;

        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            centralHorizontalLine = (this.Width / 2) - 8;
            centralVerticalLine = (this.Height / 2) - 7;
            //
            //DrawVerticalLine(Color.Red, centralHorizontalLine, 0, this.Height);// -- MARCAÇÃO VERTICAL VERTICAL USO NOS TESTES
            //DrawHorizontalLine(Color.Red, 0, this.Width, centralVerticalLine);//-7 --- MARCAÇÃO HORIZONTAL VERTICAL USO NOS TESTES
            //
            DrawVerticalLines(Color.DarkRed, centralHorizontalLine - horizontalDistance, centralVerticalLine + verticalDistance, centralHorizontalLine - horizontalDistance, centralVerticalLine - verticalDistance);//LEFT
            DrawVerticalLines(Color.DarkRed, centralHorizontalLine + horizontalDistance, centralVerticalLine + verticalDistance, centralHorizontalLine + horizontalDistance, centralVerticalLine - verticalDistance);//RIGHT
            //
            DrawVerticalLines(Color.Red, centralHorizontalLine + horizontalDistance, centralVerticalLine + (verticalDistance + 10), centralHorizontalLine - horizontalDistance, centralVerticalLine - (verticalDistance + 10));//BARRA DIAGONAL
            //
            DrawHorizontalLine(Color.Black, 0, this.Width, centralVerticalLine - 170);//TOP LINE
            //
            DrawCircle(Color.Black, centralHorizontalLine, centralVerticalLine + 124);//BOTTOM CIRCLE
        }

        private void DrawHorizontalLine(Color color, int x1, int x2, int y)
        {
            graphics = this.CreateGraphics();
            graphics.DrawLine(new Pen(new SolidBrush(color), 40), x1, y, x2, y);
        }

        private void DrawVerticalLine(Color color, int x, int y1, int y2)
        {
            graphics = this.CreateGraphics();
            graphics.DrawLine(new Pen(new SolidBrush(color), 2), x, y1, x, y2);
        }

        private void DrawVerticalLines(Color color, int x1, int y1, int x2, int y2)
        {
            graphics = this.CreateGraphics();
            graphics.DrawLine(new Pen(new SolidBrush(color), 50), x1, y1, x2, y2);
        }

        private void DrawCircle(Color color, int x, int y)
        {
            graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle((x - (circleSize / 2)), y, circleSize, circleSize);
            graphics.FillEllipse(new SolidBrush(color), rectangle);
        }
    }
}
