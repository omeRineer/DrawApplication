using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication.Shapes
{
    public class DiagonalShape : Shape, IDiagonal
    {
        public int DiagonalNumber { get; set; }

    }
}
