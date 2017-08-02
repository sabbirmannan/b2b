using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PackageBD.Areas.Agent.Controllers
{
    public class HotelController : Controller
    {
        // GET: Agent/Hotel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchHotel()
        {
            return View();
        }
    }
}