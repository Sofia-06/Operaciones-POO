using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpBásicas
{
    class Operaciones
    {
        public Opbasicas opera = new Opbasicas();
        public double n = 0;

        public string Resultado(char t)
        {
            double total = 0;

            char op = 's';
            

            while (op != 'n')
            {
                if (t == 'u')
                {
                    total = opera.Suma(total, pedir());
                    Console.Clear();
                }
                else if (t == 'r')
                {
                    total = opera.Resta(total, pedir());
                    Console.Clear();
                }
                else if (t == 'm')
                {
                    total = opera.Multiplicacion(total, pedir());
                    Console.Clear();
                }
                else if (t == 'd')
                {
                    total = opera.Division(total, pedir());
                    Console.Clear();
                }
                else if (t == 'p')
                {
                    total = opera.Potencia(total, pedir());
                    Console.Clear();
                }
                else if (t == 'a')
                {
                    total = opera.Radicacion(total, pedir());
                    Console.Clear();
                }
                else if (t == 'f')
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Desea ingresar otro valor? [s/n] ");
                op = char.Parse(Console.ReadLine());
                
            }
            return ("El Resultado es: " + total + "\n");


        }
        

        private double pedir()
        {
            double valor = 0;
            bool estado = false;

            while (estado == false)
            {
                Console.WriteLine("Ingrese un valor: ");
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    estado = true;
                }
                catch
                {
                    Console.WriteLine("Ingrese valores númericos");
                }

            }
            return valor;
        }
    }
}
