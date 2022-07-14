using DrawApplication.Extensions;
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
        private readonly List<DrawApplication.Colors.Color> _colors;
        private Graphics graphics;
        Bitmap bitmap;
        Shape shape;
        Shape currentShape;
        Color currentColor;
        bool mouseIsDown, isDeleted;

        public Form1(List<Shape> shapes, List<DrawApplication.Colors.Color> colors)
        {
            InitializeComponent();

            NewWorkPage();
            _colors = colors;
            _shapes = shapes;
        }
        private void cmbShapes_SelectedValueChanged(object sender, EventArgs e)
        {
            shape = (Shape)cmbShapes.SelectedItem;

        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = (DrawApplication.Colors.Color)cmbColors.SelectedItem;
            currentColor = color.Value;
            listBox1.BackColor = color.Value;
            if (currentShape != null)
            {
                currentShape.Color = color.Value;
                using (var brush = new SolidBrush(currentColor))
                {
                    currentShape.FillShape(graphics, brush);
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Çalışmayı Kaydet";
                saveDialog.Filter = "Bitmap | *.bmp| JPG File | *.jpg";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(saveDialog.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            NewWorkPage();
            listShapes.Items.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Bir Dosya Seçin";
                openFileDialog.Filter = "Bitmap | *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    NewWorkPage(new Bitmap(openFileDialog.FileName));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillShapes();
            FillColors();
        }




        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            shape = Activator.CreateInstance(shape.GetType()) as Shape;
            SetColor(currentColor);
            shape.X = e.X;
            shape.Y = e.Y;
            currentShape = null;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            using (var brush = new SolidBrush(currentColor))
            {
                shape.FillShape(graphics, brush);
            }
            mouseIsDown = false;
            SaveShape(shape);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                shape.Width = e.X - shape.X;
                shape.Height = e.Y - shape.Y;
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (mouseIsDown)
            {
                using (var brush = new SolidBrush(currentColor))
                {
                    e.Graphics.DrawShape(brush, shape);
                }
            }
            if (currentShape != null)
            {
                var rectangle = new System.Drawing.Rectangle(currentShape.X, currentShape.Y, Convert.ToInt32(currentShape.Width), Convert.ToInt32(currentShape.Height));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 5), rectangle);
            }

        }


        void SaveShape(Shape shape)
        {
            listShapes.Items.Add(shape);
        }
        void FillColors()
        {
            cmbColors.DataSource = _colors.ToList();
            cmbColors.DisplayMember = "Name";
            cmbColors.ValueMember = "Value";
        }
        void FillShapes()
        {
            cmbShapes.DataSource = _shapes.ToList();
            cmbShapes.ValueMember = "Id";
            cmbShapes.DisplayMember = "Name";
        }
        void NewWorkPage(Bitmap newBitmap = null)
        {
            bitmap = newBitmap != null ? newBitmap
                                       : new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        void SetColor(Color color)
        {
            shape.Color = color;
        }

        private void listShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShape = (Shape)listShapes.SelectedItem;
            if (!isDeleted)
            {
                foreach (var cmbShape in cmbShapes.Items)
                {
                    if (currentShape.GetType() == cmbShape.GetType())
                    {
                        cmbShapes.SelectedItem = cmbShape;
                    }
                }
                lblX.Text = currentShape.X.ToString();
                lblY.Text = currentShape.Y.ToString();
                lblW.Text = currentShape.Width.ToString();
                lblH.Text = currentShape.Height.ToString();
                listBox1.BackColor = currentShape.Color;
                pictureBox1.Image = bitmap;

            }

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            if (currentShape != null)
            {
                using (var brush = new SolidBrush(Color.White))
                {
                    var rectangle = new System.Drawing.Rectangle(currentShape.X, currentShape.Y, Convert.ToInt32(currentShape.Width), Convert.ToInt32(currentShape.Height));
                    graphics.FillRectangle(brush, rectangle);
                    pictureBox1.Image = bitmap;
                }
                listShapes.Items.Remove(currentShape);
            }
        }
    }
}
