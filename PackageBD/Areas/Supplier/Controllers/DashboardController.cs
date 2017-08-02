using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PackageBD.Areas.Supplier.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Supplier/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}