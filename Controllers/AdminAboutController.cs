using AcunmedyaAkademi2.Context;
using AcunmedyaAkademi2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademi2.Controllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAboutController
        SweetContext context = new SweetContext();

        public ActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateAbout(About about)
        {
            var value = context.Abouts.Find(about.AboutId);
            value.Description = about.Description;
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}