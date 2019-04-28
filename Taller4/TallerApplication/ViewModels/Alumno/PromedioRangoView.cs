using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Alumno
{
    public class PromedioRangoView
    {
        public IEnumerable<Examen> PormedioRango { get; set; }
        public Alumno alumno { get; set; }

        public PromedioRangoView()
        {
            PromedioRango = Enumerable.Empty<Examen>();
        }
    }
}