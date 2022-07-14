using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication.Shapes
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public abstract void FillShape(Graphics graphics, SolidBrush brush);
    }
}
