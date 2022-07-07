using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication.Shapes
{
    public class Rectangle : Shape
    {
        public override void FillShape(Graphics graphics, SolidBrush brush)
        {
            graphics.FillRectangle(brush, this.X, this.Y, this.Width, this.Height);
        }
    }
}
