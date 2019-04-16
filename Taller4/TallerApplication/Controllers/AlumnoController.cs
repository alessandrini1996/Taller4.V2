using Servicio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace TallerApplication.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly INterfaceAlumno _SerAlumno;
        public AlumnoController()
        {
            _SerAlumno = new SerAlumno();
        }

        // GET: Alumno
        [HttpGet]
        public ActionResult Index()
        {
            var model = new AlumnoViewModel()
            {
                Alumnos = _SerAlumno.ObtenerAlumno()
            };
            return View(model);
        }

        public ActionResult Examenes(String dni)
        {
            var examenes = _SerAlumno.ObtenerExamenPorAlumno(dni);
            Alumno alumno = null;

            if (examenes.Any())
                alumno = examenes.FirstOrderDefault().Alumno;
            var model = new ExamenesViewModel()
            {
                Alumno = alumno,
                Examen = examenes
            };
            return View(model);
        }
    }
}
