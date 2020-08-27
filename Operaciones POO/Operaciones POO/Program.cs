using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_POO
{
    class Program
    {
        static Operar operaciones = new Operar();
        static Menu m = new Menu();
        static void Main(string[] args)
        {
            int opciones = 0;

            while (opciones != 4)
            {
                opciones = m.ListaMenu();
                if (opciones == 1)
                {
                    Console.WriteLine(Operar.Resultado('s'));
                }
                else if (opciones==2)
                {
                    Console.WriteLine(Operar.Resultado('r'));
                }
            }
            Console.ReadKey();
        }
    }
}
