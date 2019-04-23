using Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Servicio
{

    public class SerAlumno : INterfaceAlumno
    {
        public IEnumerable<Alumno> ObtenerAlumnos()
        {
            return DataMock.Alumnos;
        }

        public IEnumerable<Examen> ObtenerExamenesPorAlumno(string dni)
        {
            var alumno = DataMock.Alumnos
             .FirstOrDefault(x => x.Dni == dni) ;

            if(alumno == null)
            {
                throw new Exception("El alumno buscado no se encontro");
            }
            return alumno.Examenes;
        }

        public IEnumerable<Materia> ObtenerMateriasActivasDelAlumno(string dni)
        {
            var alumno = DataMock.Alumnos
                .FirstOrDefault(x => x.Dni == dni);
            if (alumno == null)
            {
                throw new Exception("El alumno buscado no se encontro");
            }
            return alumno.Materias;
        }

        public float ObtenerPromedioPorAlumno(string dni)
        {
            var alumno = DataMock.Alumnos
                .FirstOrDefault(x => x.Dni == dni);
            if (alumno == null)
            {
                throw new Exception("El alumno buscado no se encontro");
            }

            return alumno.Examenes.Average(x => x.Nota);
        }

        public float ObtenerPromedioPorFechasDeAlumno(string dni, DateTime desde, DateTime hasta)
        {

            var alumno = DataMock.Alumnos
                .FirstOrDefault(x => x.Dni == dni);
            if (alumno == null)
            {
                throw new Exception("El alumno buscado no se encontro");
            }
            if(alumno.Examenes.FirstOrDefault(f => f.Fecha >= desde) == alumno.Examenes.FirstOrDefault( f => f.Fecha <= hasta))
            {
                throw new Exception("La fecha solicitada no se encontro");
            }
            return alumno.Examenes.Average(x => x.Nota);
        }

        

    }
}
