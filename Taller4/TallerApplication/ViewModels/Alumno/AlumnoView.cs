using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.Views.ViewsModel.Alumno
{
    public class AlumnoView
    {
        public IEnumerable<AlumnoViewI> Alumnos { get; set; }

        public AlumnoView()
        {
            Alumnos = Enumerable.Empty<AlumnoViewI>();
        }
    }
}