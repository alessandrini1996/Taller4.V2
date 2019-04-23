using System;
using Domino;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.Views.ViewsModel.Alumno
{
    public class ExamenesView
    {
        public IEnumerable<Examen> Examenes { get; set; }
        public Alumno alumno { get; set; }

        public ExamenesView()
        {
            Examenes = Enumerable.Empty<Examen>();
        }

    }
}