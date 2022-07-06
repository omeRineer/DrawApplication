using DrawApplication.Shapes;
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
        private readonly List<IShape> _shapes;
        private readonly List<Color> _colors;
        private readonly Graphics graphics;
        int X, Y, ShapeWidth, ShapeHeight;
        Color currentColor;

        public Form1(List<IShape> shapes,List<Color> colors)
        {
            InitializeComponent();

            graphics = pictureBox1.CreateGraphics();
            _shapes = shapes;
            _colors = colors;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var fileDialog=new OpenFileDialog())
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Form.DefaultBackColor);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbShapes.DataSource = _shapes.ToList();
            cmbShapes.DisplayMember = "Name";

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ShapeHeight = Math.Abs(e.Y - Y);
            ShapeWidth = Math.Abs(e.X - X);
            using (var brush=new SolidBrush(currentColor))
            {
                graphics.FillRectangle(brush, X, Y, ShapeWidth, ShapeHeight);
            } 
        }
    }
}
