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
        private readonly List<Shape> _shapes;
        private readonly List<Color> _colors;
        private readonly Graphics graphics;
        public Shape shape;
        Color currentColor = Color.Red;

        public Form1(List<Shape> shapes, List<Color> colors)
        {
            InitializeComponent();

            graphics = pictureBox1.CreateGraphics();
            _shapes = shapes;
            _colors = colors;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
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

        private void cmbShapes_SelectedValueChanged(object sender, EventArgs e)
        {

            shape = (Shape)cmbShapes.SelectedItem;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbShapes.DataSource = _shapes.ToList();
            cmbShapes.ValueMember = "Id";
            cmbShapes.DisplayMember = "Name";

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shape.X = e.X;
            shape.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shape.Height = Math.Abs(e.Y - shape.Y);
            shape.Width = Math.Abs(e.X - shape.X);
            using (var brush = new SolidBrush(shape.Color))
            {
                shape.FillShape(graphics, brush);
            }
        }

        void FillColors()
        {
            var array = _colors.ToArray();
            int satir = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(array.Length / 3)));
            int sutun = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(array.Length % 3) + 1));
            Button[,] buttons = new Button[satir, sutun];
            int xPoint = 20, yPoint = 50, index = 0;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].BackColor = array[index];
                    buttons[i, j].Size = new Size(60, 60);
                    buttons[i, j].Location = new Point(xPoint, yPoint);
                    groupBox2.Controls.Add(buttons[i, j]);
                    xPoint += 66;
                    index++;
                }
                xPoint = 20;
                yPoint += 66;
            }
        }

    }
}
