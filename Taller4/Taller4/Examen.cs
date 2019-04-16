using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    [Serializable]
    public class Examen
    {
        public string dia { get; set; }
        public int nota { get; set; }
        Alumno alumno;
        Materia materia;

        public Examen(Alumno alumno, string dia, int nota, Materia materia)
        {
            this.alumno = alumno;
            this.dia = dia;
            this.nota = nota;
            this.materia = materia;
        }
    }
}
