using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using WorldNomads.Web.Models;
using WorldNomads.Lib;

namespace WorldNomads.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult EnumerateSequences()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnumerateSequences(uint number)
        {
            var generator = new SequenceFactory();
            var result = new SequencesModel( generator.EnumerateAll(number) );
            return View(result);
        }

        public ActionResult Index()
        {
            return RedirectToAction("EnumerateSequences");
        }
    }
}