using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademi2.Context;

namespace AcunmedyaAkademi2.Controllers
{
    public class ProductController : Controller
    {
        SweetContext context = new SweetContext();
        public ActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}