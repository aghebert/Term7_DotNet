using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace MVC_Lab1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Action1()
        {
           CultureInfo[] languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
           
            return View(languages);
        }

        public ActionResult ShowLanguages()
        {
            var viewModel = new Demos.ViewModels.Home.ShowLanguagesViewModel(
                CultureInfo.GetCultures(CultureTypes.SpecificCultures));
            return View(viewModel);

        }
    }
}