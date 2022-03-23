using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csEquipo
    {
        IDictionary<int, string> equipos;

        public csEquipo(IDictionary<int, string> equipos)
        {
            this.equipos = equipos;
        }

        public string calcularMarcador()
        {
            List<int> list = new List<int>();

            foreach (KeyValuePair<int, string> item in equipos) {
                list.Add(item.Key);
            }

            if (list[0] < list[1])
            {
                return "El equipo ganador es: " + equipos[list[1]];
            }

            return "El equipo ganador es: " + equipos[list[0]];

        }

    }
}
