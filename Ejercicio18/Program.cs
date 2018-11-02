using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
  public class Program
  {
    static void Main(string[] args)
    {
        Punto vert1 = new Punto(5, 10);
        Punto vert3 = new Punto(3, 15);
        Rectangulo elRectangulo = new Rectangulo(vert1, vert3);

      Console.WriteLine("Valores de Area: " + elRectangulo.Area() + "\nValores de Parametro: " + elRectangulo.Perimetro());
      Console.ReadKey();
    }
  }
}
