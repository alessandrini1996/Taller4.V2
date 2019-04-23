using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.Views.ViewsModel.Alumno
{
    public class AlumnoViewI
    {
        public string ApellidoNombre { get; set; }
        public int Dni { get; set; }
        public int Edad { get; set; }
        public int CantMaterias { get; set; }
        public int CantExamenes { get; set; }

        public AlumnoViewI(Alumno alumno)
        {
            ApellidoNombre = alumno.ApellidoNombre;
            Dni = alumno.Dni;
            CantMaterias = alumno.CantMaterias;
            CantExamenes = alumno.CantExamenes;
            Edad = $"{ alumno.Edad} años";
        }
    }
}