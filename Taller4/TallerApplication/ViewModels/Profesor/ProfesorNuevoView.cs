using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Profesor
{
    public class ProfesorNuevoView
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
        
        public AlumnoProfesorView(Profesor profNuevo)
        {
            Dni = profNuevo.Dni;
            Nombre = profNuevo.Nombre;
            Apellido = profNuevo.Apellido;
            Legajo = profNuevo.Legajo;
        }
    }
}