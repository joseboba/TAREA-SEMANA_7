using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csVolumen
    {
        double radio;
        double altura;

        public csVolumen(double radio, double altura)
        {
            this.radio = radio; 
            this.altura = altura;   
        }

        public double calcularVolumen()
        {
            return Math.PI * Math.Pow(radio,2) * altura;
        }

    }
}
