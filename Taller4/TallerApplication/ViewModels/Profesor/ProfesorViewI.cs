using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Profesor
{
    public class ProfesorViewI
    {
        public string ApellidoNombre { get; set; }
        public string Dni { get; set; }
        public string Edad { get; set; }
        public string Legajo { get; set; }
        public int CantAulas { get; set; }

        public ProfesorViewI(Profesor profesor)
        {
            ApellidoNombre = profesor.ApellidoNombre;
            Dni = profesor.Dni;
            Edad = profesor.Edad;
            Legajo = profesor.Legajo;
            CantAulas = profesor.Materias.Select(x => x.AulaAsignada).Distinct().Count();
        }

    }
}