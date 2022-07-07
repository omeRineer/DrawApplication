using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication.Extensions
{
    public static class GraphicExtensions
    {
        public static void FillSquare(this Graphics graphics,SolidBrush brush,int x,int y,float length)
        {
            graphics.FillRectangle(brush,x,y,length,length);
        }
    }
}
