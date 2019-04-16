using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public interface INterfaceAlumno
    {
        List<Alumno> ObtenerAlumnos();

        List<Examen> ObtenerExamenesPorAlumno(string dni);

        float ObtenerPromedioPorAlumno(string dni);

        float ObtenerPromedioPorFechasDeAlumno(string dni, DateTime desde, DateTime hasta);

        List<Materia> ObtenerMateriasActivasDeAlumno(string dni);
    }
}
