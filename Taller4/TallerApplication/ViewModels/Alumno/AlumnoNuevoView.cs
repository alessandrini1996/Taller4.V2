using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Alumno
{
    public class AlumnoNuevoView
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public AlumnoNuevoView(Alumno alumNuevo)
        {
            Dni = alumNuevo.Dni;
            Nombre = alumNuevo.Nombre;
            Apellido = alumNuevo.Apellido;
            FechaNacimiento = alumNuevo.FechaNacimiento;
        }
    }
}