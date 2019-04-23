using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Profesor
{
    public class AulaViewI
    {
        public string piso { get; set; }
        public string sala { get; set; }
        public string materia { get; set; }
        
        public AulaViewI(Aula aula)
        {
            piso = aula.piso;
            sala = aula.sala;
            materia = aula.Materia.Nombre;
        }
    }
}