using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {
        private int cantidadSumas;

        public static implicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {

            return true;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {

            return 0;
        }

        public Sumador():this(0)
        {
            
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            long sumaLongs = a + b;
            cantidadSumas=(int)(cantidadSumas + 1 + sumaLongs);
            return this.cantidadSumas;
        }

        public string Sumar(string a, string b)
        {

            return "";
        }
    }

}
