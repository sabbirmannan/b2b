using PackageBD.Areas.Supplier.Models;
using PackageBD.DAL;
using PackageBD.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PackageBD.Areas.Agent.Controllers
{
    public class HomeController : Controller
    {
        private PackageDBContext db = new PackageDBContext();

        const int RecordsPerPage = 5;

        //I am not using httpGet or httpPost because it will be used for both
        public ActionResult Index(TourPackageSearchModel model)
        {
            if (!string.IsNullOrEmpty(model.SearchButton) || model.Page.HasValue)
            {
                //var entities = new NorthwindEntities();
                var results = db.TourPackages
                    .Where(p => (p.TourDestination.StartsWith(model.Destination) || model.Destination == null)
                    /*|| (p.TotalNights > model.Nights || model.Nights == null)*/)
                    .OrderBy(p => p.TourDestination);

                var pageIndex = model.Page ?? 1;
                model.SearchResults = results.ToPagedList(pageIndex, RecordsPerPage);
            }
            return View(model);
        }


        public async Task<ActionResult> TourPackageDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TourPackage tourPackage = await db.TourPackages.FindAsync(id);

            var files = db.FileDetail.ToList();

            var vm = new TourPackageViewDetailsVM
            {
                TourPackage = tourPackage,
                FileDetail=files
            };

            //Product product = await db.Products.FindAsync(id);
            if (vm == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }





        // GET: Agent/Home
        public ActionResult Indextest(string q)
        {

            //var package = db.TourPackages.ToList();
            ////package images
            //var file = db.FileDetail.ToList();

            //var vm = new PackageViewModel
            //{
            //    Pakcage_IE=package,
            //    Files_IC=file
            //};

            //return View(vm);

            var package = from p in db.TourPackages select p;
            if (!string.IsNullOrWhiteSpace(q))
            {
                package = package.Where(p => p.TourPackageTitle.Contains(q));
            }
            return View(package);
        }


    }

}