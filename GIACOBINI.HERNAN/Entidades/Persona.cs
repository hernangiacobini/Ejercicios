using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public string Apellido
        {
            get
            {
            }
        }
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0}, Apellido: {1}, Documento: {2}\n", this.nombre, this.apellido, this.documento);
            return datos.ToString();
        }
        public Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.documento = documento;
            this.nombre = nombre;
        }
        protected abstract bool ValidarDocumentacion(string doc);
        
    }
}
