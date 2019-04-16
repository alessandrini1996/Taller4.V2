using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public interface INterfaceProfesor
    {
        IEnumerable<Profesor> ObtenerProfesor();
        IEnumerable<Aula> ObtenerAulaDeProfesor(String dni);
    }
}
