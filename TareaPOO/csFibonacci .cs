using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csFibonacci
    {
        int numero;

        public csFibonacci(int numero)
        {
            this.numero = numero;   
        }

        public string calculoFibonacci()
        {
            int a = 0, b = 1, c = 0;
            string result = "0,";
            for (int i = 1; i < numero; i++)
            {
                c = a + b;
                a = b;
                b = c;

                if (i == (numero - 1))
                {
                    result += a;
                }
                else
                {
                    result += a + ",";
                }
            }
            return result;
        }
    }
}
