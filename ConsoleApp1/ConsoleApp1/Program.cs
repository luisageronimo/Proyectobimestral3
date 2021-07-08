using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = 0;
            int total = 0;
            double x = 1;
            char op = 's';
            int f;

            while (op == 's')
            {
                Console.WriteLine("Bienvenido aqui categorizaremos su IMC");

                Console.Write("Ingrese su peso en libras actual: ");
                val1 = int.Parse(Console.ReadLine());
                int total1 = (val1 * 703);



                Console.WriteLine("Ingrese su estatura en pulgadas: ");
                val2 = int.Parse(Console.ReadLine());
                int total2 = (val2 * val2);

                Console.WriteLine("Su indice de masa corporal es de: " + total1 / total2);

                Console.Write("Si desea categorizar si IMC presione 1 ");
                f = int.Parse(Console.ReadLine());
                if (f == 1)
                {
                    x = total1 / total2;
                    Console.Clear();

                    if (x < 18.5)
                    {
                        Console.WriteLine("tipo: peso bajo ");
                    }

                    if (x > 18.5)
                    {
                        if (x < 24.9)
                        {
                            Console.WriteLine("tipo: normal");
                        }
                    }
                    if (x > 25.00)
                    {
                        if (x < 29.99)
                        {
                            Console.WriteLine("tipo: Preobeso");
                        }
                    }
                    if (x > 34.99)
                    {
                        Console.WriteLine("tipo: obeso 1");
                    }
                    if (x > 39.99)
                    {
                        Console.WriteLine("tipo: obeso 2");
                    }
                    if (x > 40)
                    {
                        Console.WriteLine("tipo: obeso 3");
                    }

                }

                Console.WriteLine("Desea realizar otro ['s/n'] ");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Fin");
            Console.ReadKey();

        }
    }
}
