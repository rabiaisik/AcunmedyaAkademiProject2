using AcunmedyaAkademi2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademi2.Controllers
{
    public class AdminStatisticController : Controller
    {
        // GET: AdminStatistic
        SweetContext context = new SweetContext();

        public ActionResult StatisticList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}