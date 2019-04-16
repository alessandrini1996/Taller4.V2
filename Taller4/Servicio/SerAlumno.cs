using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class SerAlumno : INterfaceAlumno
    {
        public List<Alumno> ObtenerAlumnos()
        {
            return DataMock.Alumnos;
        }

        public List<Examen> ObtenerExamenesPorAlumno(string dni)
        {

        }
    }
}
