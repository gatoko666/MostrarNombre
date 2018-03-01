using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HolaMundoC
{
    class Program
    {
        static void Main(string[] args)
        {

            PreguntaNombreyEdad();
        }



        static void PreguntaNombreyEdad()
        {
            string nombre;
            int edad;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            string output = string.Format("Su nombre es {0} y tiene {1} años de edad.", nombre, edad);
            Console.WriteLine(output);
            Console.Read();
        }
    }
}
