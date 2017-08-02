using PackageBD.DAL;
using PackageBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PackageBD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult SendQuery(Contact contact)
        {
            using(PackageDBContext db=new PackageDBContext())
            {
                var cont = db.Contacts.Add(contact);
                db.SaveChanges();
                return Json(cont, JsonRequestBehavior.AllowGet);
            }      
        }
    }
}