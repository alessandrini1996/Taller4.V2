using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public interface INterfaceProfesor
    {
        List<Profesor> ObtenerProfesor();
        List<Aula> ObtenerAulaDeProfesor(String dni);
    }
}
