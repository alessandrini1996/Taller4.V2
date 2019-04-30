using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Alumno
{
    public class MateriaActivaView
    {
        public IEnumerable<Materia> MateriaActiva { get; set; }
        public Alumno alumno { get; set; }

        public MateriaActivaView()
        {
            MateriaActiva = Enumerable.Empty<Materia>();
        }
    }
}