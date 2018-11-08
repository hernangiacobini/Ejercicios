using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Euro
  {
    private double cantidad;
    private float cotizRespectoDolar;

    private Euro()
    {

    }
    public Euro(double cantidad)
    {

    }
    public Euro(double cantidad, float cotizacion)
    {
      
    }
    public static explicit operator Dolar(Euro p)
    {

    }
    public static explicit operator Pesos(Euro e)
    {

    }
    public double GetCantidad()
    {

    }
    public float GetCotizacion()
    {

    }
    public static implicit operator Euro(double d)
    {

    }
    public static bool operator !=(Euro e, Dolar d)
    {

    }
    public static bool operator !=(Euro e, Pesos p)
    {

    }
    public static bool operator !=(Euro e1, Euro e2)
    {

    }
    public static bool operator -(Euro e, Dolar d)
    {

    }
    public static bool operator -(Euro e, Pesos p)
    {

    }
    public static bool operator +(Euro e, Dolar d)
    {

    }
    public static bool operator +(Euro e, Pesos p)
    {

    }
    public static bool operator ==(Euro e, Dolar d)
    {

    }
    public static bool operator ==(Euro e, Pesos p)
    {

    }
    public static bool operator ==(Euro e1, Euro e2)
    {

    }
  }
}
