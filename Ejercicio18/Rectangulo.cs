using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
  public class Rectangulo
  {
    private float area;
    private float perimetro;
    private Punto vertice1;
    private Punto vertice2;
    private Punto vertice3;
    private Punto vertice4;

    public float Area()
    {
      float baseRectangulo = Math.Abs(vertice1.GetX()) + Math.Abs(vertice3.GetX());
      float alturaRectangulo = Math.Abs(vertice1.GetY()) + Math.Abs(vertice3.GetY());

      this.area = baseRectangulo * alturaRectangulo;
      
        return this.area;
    }

    public float Perimetro()
    {
      float baseRectangulo = Math.Abs(vertice1.GetX()) + Math.Abs(vertice3.GetX());
      float alturaRectangulo = Math.Abs(vertice1.GetY()) + Math.Abs(vertice3.GetY());

      this.perimetro=(baseRectangulo+alturaRectangulo)*2;
      return this.perimetro;
    }

    public Rectangulo(Punto vertice1, Punto vertice3)
    {
      this.vertice1 = vertice1;
      this.vertice3 = vertice3;      
    }
  }
}
