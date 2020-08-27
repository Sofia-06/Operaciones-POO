using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpBásicas
{
    class Program
    {
        static Operaciones opera = new Operaciones();
        static Menu y = new Menu();
        static void Main(string[] args)
        {
            int opciones = 0;

            while (opciones != 7)
            {
                opciones = y.ListaMenu();
                if (opciones == 1)
                {
                    Console.WriteLine(opera.Resultado('u'));
                }
                else if (opciones == 2)
                {
                    Console.WriteLine(opera.Resultado('r'));
                }
                else if (opciones == 3)
                {
                    Console.WriteLine(opera.Resultado('m'));
                }
                else if (opciones == 4)
                {
                    Console.WriteLine(opera.Resultado('d'));
                }
                else if (opciones == 5)
                {
                    Console.WriteLine(opera.Resultado('p'));
                }
                else if (opciones == 6)
                {
                    Console.WriteLine(opera.Resultado('a'));
                }
                else if (opciones == 7)
                {
                    Console.WriteLine(opera.Resultado('f'));
                }
            }
            Console.ReadKey();
        }
    }
}
