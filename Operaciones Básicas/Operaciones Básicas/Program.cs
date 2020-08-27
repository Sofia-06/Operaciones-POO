using System;

namespace Operaciones_Básicas
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
                    Console.WriteLine(opera.Resultado('s'));
                }
                else if (opciones == 2)
                {
                    Console.WriteLine(opera.Resultado('r'));
                }
            }
            Console.ReadKey();
        }
    }
}
