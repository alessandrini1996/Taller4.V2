using Servicio;
using Dominio;
using System;
using TallerApplication.ViewModels.Alumno;
using TallerApplication.ViewModels.Profesor;
using System.Linq;
using System.Web.Mvc;

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

            var model = new ExamenesView()
            {
                Alumno = alumno,
                Examen = examenes
            };
            return View(model);
        }

        public ActionResult Promedio(string dni)
        {
            var promedios = _SerAlumno.ObtenerPromedioPorAlumno(dni);
            Alumno alumno = null;

            if (promedios.Any())
                alumno = promedios.FirstOrderDefault().Alumno;

            var model = new PromediosView()
            {
                Alumno = alumno,
                Promedio = promedios
            };
            return View(model);
        }
        public ActionResult PromedioPorRango (string dni, DateTime desde, DateTime hasta)
        {
            var promedioPorRango = _SerAlumno.ObtenerPromedioPorFechasDeAlumno(dni, hasta, desde);
            Alumno alumno = null;

            var model = new PromedioRangoView()
            {
                Alumno = alumno,
                PromedioPorRango = promedioPorRango
            };
            return View(model);
        }
        public ActionResult MateriaActiva (string dni)
        {
            var materiasActivas = _SerAlumno.ObtenerMateriasActivasDelAlumno(dni);
            Alumno alumno = null;

            var model = new MateriaActivaView()
            {
                Alumno = alumno,
                MateriaActiva = materiasActivas
            };
            return View(model);
        }
        //decimal? ObtenerPromedioPorAlumno(string dni);
        //decimal? ObtenerPromedioEnRangoDeFechasPorAlumno(string dni, DateTime desde, DateTime hasta);
        //IEnumerable<Materia> ObtenerMateriasActivasPorAlumno(string dni);
    }
}
