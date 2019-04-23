using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Profesor
{
    public class AulaView
    {
        public IEnumerable<AulaViewI> Aulas { get; set; }
        public Profesor profesor { get; set; }

        public AulaView()
        {
            Aulas = Enumerable.Empty<AulaViewI>();
        }
    }
}