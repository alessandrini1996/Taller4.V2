using Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Servicio
{

    public class SerProfesor : INterfaceProfesor
    {
        public IEnumerable<Profesor> ObtenerProfesor()
        {
            return DataMock.Profesores;
        }

        public IEnumerable<Aula> ObtenerAulaDeProfesor(String dni)
        {
            var profesor = DataMock.Profesores.FirstOrDefault(x => x.Dni == dni);

            if (profesor == null)
                throw new Exception("El profesor no existe.");

            return profesor.Materias.(materia => materia.AulaAsignada);
        }
    }
}
