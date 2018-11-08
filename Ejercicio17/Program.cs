using Ejercicio17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            string textoColor;

      Console.ForegroundColor = azul.GetColor();
      azul.Pintar(20, out textoColor);

      Console.ForegroundColor = rojo.GetColor();
      rojo.Pintar(40, out textoColor);

      Console.ReadKey();
        }
    }
}
