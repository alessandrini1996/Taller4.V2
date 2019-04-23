using Dominio;
using System;
using System.Collections.Generic;


namespace Servicio
{
    public interface INterfaceAlumno
    {
        IEnumerable<Alumno> ObtenerAlumnos();

        IEnumerable<Examen> ObtenerExamenesPorAlumno(string dni);

        float ObtenerPromedioPorAlumno(string dni);

        float ObtenerPromedioPorFechasDeAlumno(string dni, DateTime desde, DateTime hasta);

        IEnumerable<Materia> ObtenerMateriasActivasDeAlumno(string dni);
    }
}
