using AcunmedyaAkademi2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademi2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        SweetContext context = new SweetContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            var values = context.Sliders.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialLast6Product()
        {
            var values = context.Products.OrderByDescending(x=> x.ProductId).Take(6).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService() 
        {
            var values = context.Services.ToList();
            return PartialView(values); 
        }

        public PartialViewResult PartialTestimonial() 
        { 
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
    }
}