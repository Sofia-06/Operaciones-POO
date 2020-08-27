using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_POO
{
    class Operar
    {
        public Op opera = new Op();
        public double n = 0;

        public string Resultado(char t)
        {
            double total = 0;

            char op = 's';

            while(op!='n')
            {
                if (t=='s')
                {
                    total = opera.Suma(total, pedir());
                }
                else if (t=='r')
                {
                    total = opera.Resta(total, pedir());
                }
                Console.WriteLine("Desea ingresar otro valor? [s/n] ");
                op = char.Parse(Console.ReadLine());
            }
            return ("El Resultado es: " + total);

        }

        private double pedir()
        {
            double valor = 0;
            bool estado = false;

            while(estado == false)
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
