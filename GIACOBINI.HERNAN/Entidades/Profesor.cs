using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad { get; }

        public override string ExponerDatos()
        {
            return "";
        }
        public Profesor(string nombre, string apellido, string documento):base(nombre, apellido, documento)
        {

        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso):base(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
    }
}
