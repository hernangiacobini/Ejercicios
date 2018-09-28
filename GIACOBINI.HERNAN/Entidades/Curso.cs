using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision { get; }

        private Curso()
        {

        }
        private Curso(short anio, Divisiones division, Profesor profesor)
        {

        }
        explicit operator string(Curso c);
        public static bool operator !=(Curso c, Alumno a)
        {

        }
        public static Curso operator +(Curso c, Alumno a)
        {

        }
        public static bool operator ==(Curso c, Alumno a)
        {

        }
    }
}
