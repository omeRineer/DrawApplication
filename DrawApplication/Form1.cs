using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApplication
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        SolidBrush solid = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }
        int X,Y,ShapeWidth,ShapeHeight;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            X = point.X;
            Y = point.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            ShapeHeight = Math.Abs(point.Y - Y);
            ShapeWidth = Math.Abs(point.X - X);
            graphics.FillRectangle(solid, X, Y, ShapeWidth, ShapeHeight);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
