using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    class FiguraGeometrica
    {
        public double base_;
        public double altura;
        public double radio;

        public virtual void Area() { }
        public virtual void Perimetro() { }
    }
}
