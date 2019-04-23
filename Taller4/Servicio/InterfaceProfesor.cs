using Dominio;
using System;
using System.Collections.Generic;


namespace Servicio
{
    public interface INterfaceProfesor
    {
        IEnumerable<Profesor> ObtenerProfesor();
        IEnumerable<Aula> ObtenerAulaDeProfesor(String dni);
    }
}
