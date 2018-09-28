using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + division;
            }
        }
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }
        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Año: {0}, Division: {1}\n", this.anio, this.division);
            return datos.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length == 9)
            {
                for (int i = 0; i < doc.Length; i++)
                {
                    if (i == 2 || i == 7)
                    {
                        if (doc[i] != '-')
                        {
                            return false;
                        }
                    }
                    //validar numeros
                }
            }
            return true;
        }
    }
}
