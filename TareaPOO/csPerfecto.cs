using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csPerfecto
    {
        int numero;

        public csPerfecto(int numero)
        {
            this.numero = numero;
        }

        public String calcularPerfecto()
        {
            int acum = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0) acum += i;
            }

            if (acum == numero)
            {
                return "Es un número perfecto";
            }

            return "No es un número perfecto";
        }

    }
}
