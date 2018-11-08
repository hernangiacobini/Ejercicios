using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";

            short nivelTinta = (short)(this.tinta - gasto);
            if (nivelTinta >= 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo = dibujo + "*";
                }
                Console.WriteLine("{0}", dibujo);
                SetTinta(nivelTinta);
                return true;
            }
            else
            {
        Console.WriteLine("El valor supera la cantidad de tinta que posee el boligrafo");
            }
            return false;
        }

        public void Recargar()
        {
            short tintaActual = GetTinta();
            short tintaNecesaria = (short)(cantidadTintaMaxima - tintaActual);
            SetTinta(tintaNecesaria);
        }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            
            if (tinta <= cantidadTintaMaxima && tinta >= -cantidadTintaMaxima)
            {
                short auxTinta = (short)(cantidadTintaMaxima + tinta);
                if (auxTinta >= 0 && auxTinta <= cantidadTintaMaxima)
                    this.tinta = auxTinta;
            }
            else
                Console.WriteLine("No es posible asignar esa cantidad");
        }
    }
}
