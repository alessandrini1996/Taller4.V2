using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{

    public class SerProfesor : INterfaceProfesor
    {
        public List<Profesor> ObtenerProfesor()
        {
            return DataMock.Profesores;
        }
    }
}
