using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Alumno
{
    public class PromedioView
    {
        public IEnumerable<Examen> Promedio { get; set; }
        public Alumno alumno { get; set; }

        public PromedioView()
        {
            Promedio = Enumerable.Empty<Examen>();
        }
    }
}