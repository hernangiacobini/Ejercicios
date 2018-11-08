using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Pesos
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    static Pesos()
    {
      Pesos.cotizRespectoDolar=38.33f;
    }
    public Pesos(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Pesos(double cantidad, float cotizacion):this(cantidad)
    {
      Pesos.cotizRespectoDolar = cotizacion;
    }
    public static explicit operator Dolar(Pesos p)
    {
    }
    public static explicit operator Euro(Pesos p)
    {

    }
    public double GetCantidad()
    {
      return this.cantidad;
    }
    public float GetCotizacion()
    {
      return cotizRespectoDolar;
    }
    public static implicit operator Pesos(double d)
    {

    }
    public static bool operator !=(Pesos p, Dolar d)
    {

    }
    public static bool operator !=(Pesos p, Euro e)
    {

    }
    public static bool operator !=(Pesos p1, Pesos p2)
    {

    }
    public static bool operator -(Pesos p, Dolar d)
    {

    }
    public static bool operator -(Pesos p, Euro e)
    {

    }
    public static bool operator +(Pesos p, Dolar d)
    {

    }
    public static bool operator +(Pesos p, Euro e)
    {

    }
    public static bool operator ==(Pesos p, Dolar d)
    {

    }
    public static bool operator ==(Pesos p, Euro e)
    {

    }
    public static bool operator ==(Pesos p1, Pesos p2)
    {

    }
  }
}
