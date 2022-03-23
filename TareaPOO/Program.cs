using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.Clear();
            int opcion;
            Console.WriteLine("Ingrese la opción que desea trabajar");
            Console.WriteLine("1. Pago de autobus");
            Console.WriteLine("2. Calcular billetes");
            Console.WriteLine("3. Número perfecto");
            Console.WriteLine("4. Persona con la menor edad");
            Console.WriteLine("5. Calcular entero");
            Console.WriteLine("6. Volumen cilindro");
            Console.WriteLine("7. Calcular resultado");
            Console.WriteLine("8. Calcular MCD");
            Console.WriteLine("9. Fibonacci");
            Console.WriteLine("10. Tablas");
            opcion = int.Parse(Console.ReadLine()); 

            switch (opcion)
            {
                case 1:
                    pagoAutobus();  
                    Console.ReadKey();
                    menu();
                    break;
                case 2:
                    calcularBilletes();
                    Console.ReadKey();
                    menu();
                    break;
                case 3:
                    numeroPerfecto();
                    Console.ReadKey();
                    menu();
                    break;
                case 4:
                    personaMenorEdad();
                    Console.ReadKey();
                    menu();
                    break;
                case 5:
                    calcularEntero();
                    Console.ReadKey();
                    menu();
                    break;
                case 6:
                    calcularVolumen();
                    Console.ReadKey();
                    menu();
                    break;
                case 7:
                    calcularResultado();
                    Console.ReadKey();
                    menu();
                    break;
                case 8:
                    calcularMcd();
                    Console.ReadKey();
                    menu();
                    break;
                case 9:
                    calcularFibonacci();
                    Console.ReadKey();
                    menu();
                    break;
                case 10:
                    tablas();
                    Console.ReadKey();
                    menu();
                    break;
                default:
                    menu();
                    break;
            }

        }

        static void pagoAutobus()
        {
            int nAlumnos;
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de alumnos que usaran el autobus");
            nAlumnos = int.Parse(Console.ReadLine());

            csPagoAutobus c = new csPagoAutobus(nAlumnos);
            Console.WriteLine("El total a pagar por alumno es: " + c.calcularPagoIndividual());
            Console.WriteLine("El total a pagar de autobus es: " + c.calcularPagoAutobus());
            Console.ReadKey();
        }

        static void calcularBilletes()
        {
            int dinero;
            Console.Clear();
            Console.WriteLine("Ingrese el dinero a calcular: ");
            dinero = int.Parse(Console.ReadLine()); 

            csDinero d =  new csDinero(dinero); 

            int[] list = d.calcularBilletes().ToArray();

            Console.WriteLine("Billetes de 100Q: " + list[0]);
            Console.WriteLine("Billetes de 50Q: " + list[1]);
            Console.WriteLine("Billetes de 20Q: " + list[2]);
            Console.WriteLine("Billetes de 10Q: " + list[3]);
            Console.WriteLine("Billetes de 5Q: " + list[4]);
            Console.WriteLine("Billetes de 1Q: " + list[5]);
            Console.ReadKey();
        }

        static void numeroPerfecto() {
            int numero;
            Console.Clear();
            Console.WriteLine("Ingrese el número a calcular: ");
            numero = int.Parse(Console.ReadLine()); 

            csPerfecto p = new csPerfecto(numero);
            Console.WriteLine(p.calcularPerfecto());
            Console.ReadKey();
        }

        static void personaMenorEdad()
        {
            bool validate = false;
            Console.Clear();
            IDictionary<int, string> personas = new Dictionary<int, string>(); 
            for (int i = 0; i < 3; i++) {
                int edad = 0;
                String nombre = "";

                Console.WriteLine("Ingrese el nombre de la persona " + (i+1));
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de " + nombre);
                edad = int.Parse(Console.ReadLine());

                if (personas.ContainsKey(edad))
                {
                    Console.WriteLine("No se pueden repetir las edades");
                    validate = true;
                    Console.ReadKey();
                    break;
                }
                personas.Add(edad, nombre);
            }

            if (!validate)
            {
                csEdad e = new csEdad(personas);
                Console.WriteLine(e.calcularEdad());
                Console.ReadKey();
            } else
            {
                personaMenorEdad();
            }

        }

        static void calcularEntero()
        {
            int n;
            String ns;
            Console.Clear();
            Console.WriteLine("Ingrese el número a calcular: ");
            ns = Console.ReadLine();

            if(int.TryParse(ns, out n))
            {   
                n = int.Parse(ns);
            } else
            {
                Console.WriteLine("No es un numero entero");
                Console.ReadKey();
                calcularEntero();
            }

            csEntero e = new csEntero(n);
            Console.WriteLine(e.calcularPositivo());

            Console.ReadKey();
        }

        static void calcularVolumen()
        {
            Console.Clear();
            double radio, altura;
            Console.WriteLine("Ingrese el radio del cilindro");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altira del cilindro"); 
            altura = double.Parse(Console.ReadLine());

            csVolumen v = new csVolumen(radio, altura);
            Console.WriteLine("El volumen del cilindro es: " + v.calcularVolumen());  
            Console.ReadKey();
        }

        static void calcularResultado()
        {
            Console.Clear();

            IDictionary<int, string> equipos = new Dictionary<int, string>();

            for (int i = 0; i < 2; i++)
            {
                int goles;
                String equipo;
                
                Console.WriteLine("Ingrese el equipo " + (i + 1));
                equipo = Console.ReadLine();

                Console.WriteLine("Ingrese los goles de " + equipo);
                goles = int.Parse(Console.ReadLine());

                if(equipos.ContainsKey(goles))
                {
                    Console.WriteLine("El marcador ha terminado en empate");
                    Console.ReadKey();
                    menu();
                }
                equipos.Add(goles, equipo);
               
            }

            csEquipo eq = new csEquipo(equipos);
            Console.WriteLine(eq.calcularMarcador());

            Console.ReadKey();
        }

        static void calcularMcd()
        {
            int n1, n2;
            Console.Clear();
            Console.WriteLine("Ingrese el número 1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Los números no pueden ser iguales");
                Console.ReadKey();
                calcularMcd();
            }

            csMCD mcd = new csMCD(n1, n2);
            Console.WriteLine("El MCD de " + n1 + " y " + n2 + " es " + mcd.calcularMCD());
            Console.ReadKey();
        }

        static void calcularFibonacci()
        {
            Console.Clear();
            Console.WriteLine("Ingrese cuantos números desea visualizar");
            int numero = int.Parse(Console.ReadLine());

            csFibonacci f = new csFibonacci(numero);
            Console.WriteLine(f.calculoFibonacci());

            Console.ReadKey();
        }

        static void tablas()
        {
            Console.Clear();
            
            csTabla t = new csTabla();
            Console.WriteLine(t.tabla());

            Console.ReadKey();
        }
    }
}
