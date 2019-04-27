using System;
using Servicio;
using Dominio;
using TallerApplication.ViewModels.Alumno;
using TallerApplication.ViewModels.Profesor;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerApplication.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly SerProfesor _SerProfesor;

        public ProfesorController()
        {
            _SerProfesor = new SerProfesor();
        }
        // GET: Profesor
        [HttpGet]
        public ActionResult Index()
        {
            var model = new ProfesoresView()
            {
                Profesores = _SerProfesor.ObtenerProfesor().Select(x => new ProfesorViewI(x))
            };
            return View(model);
        }

        public ActionResult Aula (string dni)
        {
            var aulas = _SerProfesor.ObtenerAulaDeProfesor(dni);
            Profesor profesor = null;

            if (aulas.Any())
                profesor = aulas.FirstOrDefault().Materia.Profesor;

            var model = new AulaView()
            {
                Profesor = profesor,
                Aula = aulas.Select(x => new AulaViewI(x))
            };

            return View(model);
        }
        //decimal? ObtenerPromedioPorAlumno(string dni);
        //decimal? ObtenerPromedioEnRangoDeFechasPorAlumno(string dni, DateTime desde, DateTime hasta);
        //IEnumerable<Materia> ObtenerMateriasActivasPorAlumno(string dni);
    }
}
