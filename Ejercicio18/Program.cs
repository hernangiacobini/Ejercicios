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

            Punto vert1 = new Punto(2, 3);
            Punto vert3 = new Punto(4, 5);
            Punto vert2 = new Punto(vert1.GetX(), vert3.GetY());
            Punto vert4 = new Punto(vert1.GetY(), vert3.GetX());

            Rectangulo elRectangulo = new Rectangulo(vert1, vert3);

            Console.WriteLine("Valores de Area: " + elRectangulo.Area() + "\nValores de Perimetro: " + elRectangulo.Perimetro());
            Console.ReadKey();

    }
  }
}
