using GlobalizationLocalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalizationLocalization.Controllers
{
    public class HomeController : Controller
    {
        private static List<Demo> _list = new List<Demo>();

        public ActionResult Index()
        {
            ViewBag.List = _list;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Demo model)
        {
            if (ModelState.IsValid)
            {
                _list.Add(model);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}