using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class csEdad
    {
        IDictionary<int, string> personas;

        public csEdad(IDictionary<int, string> personas) 
        {
            this.personas = personas;
        }

        public String calcularEdad() {
            int menor;
            List<int> list = new List<int>();

            foreach (KeyValuePair<int, string> p in personas) {
                list.Add(p.Key);
            }

            menor = list[0];
            foreach (int e in list)
            {
                if (e < menor)
                {
                    menor = e;
                }
            }

            
            return "La persona más joven es: " + personas[menor] + ", tiene " + menor + " años";
        }

    }
}
