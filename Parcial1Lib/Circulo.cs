using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    class Circulo : FiguraGeometrica
    {
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override void Area()
        {
            double area = Math.PI * Math.Pow(radio, 2);
        }
        public override void Perimetro()
        {
            double perimetro = 2 * Math.PI * radio;
        }
    }
}
