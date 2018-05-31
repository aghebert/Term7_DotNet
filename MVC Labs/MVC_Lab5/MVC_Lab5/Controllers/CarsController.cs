using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Lab5.Models;
using MVC_Lab5.ViewModels.Home;

namespace MVC_Lab5.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult CarsList()
        {
            var factory = new CarFactory();
            var viewModel = new CarsListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}