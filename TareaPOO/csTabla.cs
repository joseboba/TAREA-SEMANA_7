using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csTabla
    {

        public string tabla()
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result += "Tabla del " + i + "\n\r";

                for (int j = 1; j <= 10; j++)
                {
                    result += j + " X " + i + " = " + (j * i)  + "\n\r";
                }

                result += "\n\r";

            }
            return result;
        }

    }
}
