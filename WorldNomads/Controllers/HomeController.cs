using System;
using System.Linq;
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
            SequencesModel model;
            try
            {
                var generator = new SequenceFactory();
                model = new SequencesModel() { Sequences = generator.EnumerateAll(number) };
            }
            catch (Exception ex)
            {
                model = new SequencesModel() { Error = GetErrorMessage(ex) };
                ModelState.AddModelError("Sequences", model.Error);
            }
            return View(model);
        }

        private static string GetErrorMessage(Exception ex)
        {
            var pError = ex;
            while (pError.InnerException != null)
                pError = pError.InnerException;

            return pError.Message;
        }

        public ActionResult Index()
        {
            return RedirectToAction("EnumerateSequences");
        }
    }
}