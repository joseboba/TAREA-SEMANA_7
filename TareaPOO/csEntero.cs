using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csEntero
    {
        int numero;

        public csEntero(int numero)
        {
            this.numero = numero;   
        }

        public String calcularPositivo()
        {
            if (numero < 0)
            {
                return "Número negativo";
            }
            return "Número positivo";
        }

    }
}
