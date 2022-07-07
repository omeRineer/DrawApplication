using DrawApplication.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication.Shapes
{
    public class Square : Shape
    {
        public override void FillShape(Graphics graphics, SolidBrush brush)
        {
            graphics.FillSquare(brush, this.X, this.Y, this.Width);
        }
    }
}
