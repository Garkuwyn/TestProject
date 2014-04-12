using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GraduatesProject.DAL;
namespace GraduatesProject.Controllers
{
    public class HomeController : Controller
    {
        private GraduatesEntitiesModel graduatesEntities;
        public HomeController()
        {
            graduatesEntities = new GraduatesEntitiesModel();
        }
        public ActionResult Index()
        {
            var students = graduatesEntities.Persons.ToList();
            ViewBag.Message = "Измените этот шаблон, чтобы быстро приступить к работе над приложением ASP.NET MVC.";

            return View(students);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Страница описания приложения.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Страница контактов.";

            return View();
        }
    }
}
