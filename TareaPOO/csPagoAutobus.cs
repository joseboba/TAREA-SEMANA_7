using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csPagoAutobus
    {

        int nAlumnos;
        double pagoAlumno;


        public csPagoAutobus(int nAlumnos)
        {
            this.nAlumnos = nAlumnos;
        }
        

        public double calcularPagoIndividual()
        {
            pagoAlumno = 0;
            if (nAlumnos >= 100) {
                pagoAlumno = 65.0;
            }

            if (nAlumnos >= 50 && nAlumnos <= 99)
            {
                pagoAlumno = 70.0;
            }

            if (nAlumnos >= 30 && nAlumnos <= 49)
            {
                pagoAlumno = 95.0;
            }

            if (nAlumnos < 30)
            {
                pagoAlumno = 4000.0 / nAlumnos;
            }
            return pagoAlumno;

        }

        public double calcularPagoAutobus()
        {
            if (nAlumnos < 30)
            {
                return 4000.0;
            }


            return nAlumnos * pagoAlumno;
        }

    }
}
