using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csMCD
    {
        int n1;
        int n2;

        public csMCD(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int calcularMCD()
        {
            int a, b, res;

            a = Math.Max(n1, n2);
            b = Math.Min(n1, n2);

            do
            {
                res = b;
                b = a % b;
                a = res;
            } while (b != 0);

            return res;
        }
    }
}
