using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    [Serializable]
    public class Alumno
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public List<Materia> _Materias;
        public List<Examen> _Examenes;
        readonly Materia materia;
        readonly Examen examen;



        public Alumno(string dni, string nombre, string apellido, DateTime fechaNacimiento)
        {
            _Materias = new List<Materia>();
            _Examenes = new List<Examen>();
        }

        public void InscribirMateria(Materia materia)
        {
            _Materias.Add(materia);
        }

        public void InscibirMaterias(List<Materia> materias)
        {
            materias.Add(materia);
        }

        public void Baja(Materia materia)
        {
            if (materia == null)

                throw new Exception("El alumno:" + nombre + "no se encuentra inscripto en esta materia: ");

            _Materias.Remove(materia);
        }

        public void Evaluar(Examen examen)
        {
            _Examenes.Add(examen);
        }
    }
}
