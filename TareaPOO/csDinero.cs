using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csDinero
    {

        int dinero;

        public csDinero(int dinero)
        {
            this.dinero = dinero;
        }


        public List<int> calcularBilletes()
        {
            int b100 = 0, b50 = 0, b20 = 0, b10 = 0, b5 = 0, b1 = 0;
            List<int> list = new List<int>();   

            if (dinero >= 100)
            {
                b100 = fb100(dinero);
                dinero -= (b100 * 100);
                   
            }

            if (dinero >= 50)
            {
                b50 = fb50(dinero);
                dinero -= (b50 * 50);
            }

            if (dinero >= 20)
            {
                b20 = fb20(dinero);
                dinero -= (b20 * 20);
            }

            if (dinero >= 10)
            {
                b10 = fb10(dinero);
                dinero -= (b10 * 10);
            }

            if (dinero >= 5)
            {
                b5 = fb5(dinero);
                dinero -= (b5 * 5);
            }

            if (dinero >= 1)
            {
                b1 = fb1(dinero);
                dinero -= b1;
            }

            list.Add(b100);
            list.Add(b50);
            list.Add(b20);
            list.Add(b10);
            list.Add(b5);
            list.Add(b1);

            return list;    
        }

        static int fb100(int b)
        {
            return b / 100;
        }

        static int fb50(int b)
        {
            return b / 50;
        }

        static int fb20(int b)
        {
            return b / 20;
        }

        static int fb10(int b)
        {
            return b / 10;
        }

        static int fb5(int b)
        {
            return b / 5;
        }

        static int fb1(int b)
        {
            return b / 1;
        }

    }
}
