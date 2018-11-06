using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador(5);
            long b = 5;
            long a = 2;
            int resultado=sum;
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
