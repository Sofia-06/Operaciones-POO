using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpBásicas
{
    class Opbasicas
    {
        public double Suma(double a, double b)
        {
            return (a + b);
        }

        public double Resta(double a, double b)
        {
            return (a-b);
        }
        public double Multiplicacion(double a, double b)
        {
            return (a * b);
        }
        public double Division(double a, double b)
        {
            return (a / b);
        }
        public double Potencia(double a, double b)
        {
            double num;
            num = Math.Pow(a, b);
            return (num);
            
        }
        public double Radicacion(double a, double b)
        {
            
            double raiz = Math.Sqrt(a);
            return (raiz);
        }



    }
}
