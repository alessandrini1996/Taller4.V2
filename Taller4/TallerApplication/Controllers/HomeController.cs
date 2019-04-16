using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new InfoViewModel()
            {
                CantidadAlumnos = 2,
                CantidadAulas = 4,
                CantidadExamenes =2,
                CantidadProfesores = 5,
                CantidadMaterias = 4
            };
            return View(model);
        }
    }
}