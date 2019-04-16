using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    [Serializable]
    public class Examen
    {
        public float Nota { get; private set; }
        public DateTime Fecha { get; private set; }
        public Materia Materia { get; private set; }
        public Alumno Alumno { get; private set; }
        
        public Examen(float nota, DateTime fecha, Alumno alumno, Materia materia)
        {
            Nota = nota;
            Fecha = fecha;
            Materia = materia;
            Alumno = alumno;
        }
        
    }
}
