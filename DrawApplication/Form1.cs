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
        private Graphics graphics;
        private readonly List<Shape> _shapes;
        private readonly List<DrawApplication.Colors.Color> _colors;
        Bitmap bitmap;
        Shape shape;
        Color currentColor;

        public Form1(List<Shape> shapes, List<DrawApplication.Colors.Color> colors)
        {
            InitializeComponent();

            NewWorkPage();
            _colors = colors;
            _shapes = shapes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Çalışmayı Kaydet";
                saveDialog.Filter = "Bitmap | *.bmp| JPG File | *.jpg";
                if (saveDialog.ShowDialog()==DialogResult.OK)
                {
                    bitmap.Save(saveDialog.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            NewWorkPage();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog=new OpenFileDialog())
            {
                openFileDialog.Title = "Bir Dosya Seçin";
                openFileDialog.Filter = "Bitmap | *.bmp";
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    NewWorkPage(new Bitmap(openFileDialog.FileName));
                }
            }
        }

        private void cmbShapes_SelectedValueChanged(object sender, EventArgs e)
        {

            shape = (Shape)cmbShapes.SelectedItem;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillShapes();
            FillColors();
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
            using (var brush = new SolidBrush(currentColor))
            {
                shape.FillShape(graphics, brush);
            }
            pictureBox1.Image = bitmap;
        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = (DrawApplication.Colors.Color) cmbColors.SelectedItem;
            currentColor = color.Value;
            listBox1.BackColor=color.Value;
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
        void NewWorkPage(Bitmap newBitmap=null)
        {
            bitmap = newBitmap!=null ? newBitmap
                                                : new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics=Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
    }
}
