using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    class Triangulo : FiguraGeometrica
    {
        public Triangulo(double base_,double altura) { 
            this.base_ = base_;
            this.altura = altura;
        }
        public override void Area()
        {
            double area = (base_ * altura) / 2;
        }
        public override void Perimetro()
        {
            double perimetro = base_ + (Math.Sqrt(Math.Pow(base_, 2) + Math.Pow(altura, 2)) * 2);
        }
    }
}
