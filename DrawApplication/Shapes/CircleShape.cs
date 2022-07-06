using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication.Shapes
{
    public class CircleShape : Shape, ICircle
    {
        public int Diameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
