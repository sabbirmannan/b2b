using PackageBD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PackageBD.Areas.Admin.Controllers
{
    public class SuppliersController : Controller
    {
        private PackageDBContext db = new PackageDBContext();
        // GET: Admin/Suppliers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewRegisters()
        {
            var suplist = db.SupplierInfos.ToList();
            return View(suplist);
        }
    }
}