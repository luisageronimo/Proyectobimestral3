using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion2
{
    class ProyectoBimestral
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = 0;
            int total = 0;
            char op = 's';

            while (op == 's')
            {

                Console.Write("Ingrese su peso en libras actual: ");
                val1 = int.Parse(Console.ReadLine());
                int total1 = (val1 * 703);

                Console.Write("Ingrese su estatura en pulgadas: ");
                val2 = int.Parse(Console.ReadLine());
                int total2 = (val2 * val2);

                Console.WriteLine("Su indice de masa corporal es de: " + total1 / total2);


                Console.WriteLine("Desea realizar otro ['s/n'] ");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Fin");
            Console.ReadKey();

        }
    }
}
