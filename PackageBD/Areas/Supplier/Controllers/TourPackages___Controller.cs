using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PackageBD.Areas.Supplier.Models;
using PackageBD.DAL;

namespace PackageBD.Areas.Supplier.Controllers
{
    public class TourPackages___Controller : Controller
    {
        private PackageDBContext db = new PackageDBContext();

        // GET: Supplier/TourPackages___
        public async Task<ActionResult> Index()
        {
            return View(await db.TourPackages.ToListAsync());
        }

        // GET: Supplier/TourPackages___/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourPackage tourPackage = await db.TourPackages.FindAsync(id);
            if (tourPackage == null)
            {
                return HttpNotFound();
            }
            return View(tourPackage);
        }

        // GET: Supplier/TourPackages___/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/TourPackages___/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TourPackageID,TourPackageTitle,Highlights,InclusionExclusion,TourDestination,SpecialNotes,TourCostPrice,TourSalesPrice,TourDiscountPrice,TotalNights,HotelStar,HotelInUse,DayWiseItienary,TearmsAndConditions,Allotment,Adults,Childrens,CreatedOn,DepartingDate,ValidityDate,DayOne,DayTwo,DayThree,DayFour,DayFive,DaySix,DaySeven,DayEight,DayNine,DayTen")] TourPackage tourPackage)
        {
            if (ModelState.IsValid)
            {
                db.TourPackages.Add(tourPackage);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tourPackage);
        }

        // GET: Supplier/TourPackages___/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourPackage tourPackage = await db.TourPackages.FindAsync(id);
            if (tourPackage == null)
            {
                return HttpNotFound();
            }
            return View(tourPackage);
        }

        // POST: Supplier/TourPackages___/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TourPackageID,TourPackageTitle,Highlights,InclusionExclusion,TourDestination,SpecialNotes,TourCostPrice,TourSalesPrice,TourDiscountPrice,TotalNights,HotelStar,HotelInUse,DayWiseItienary,TearmsAndConditions,Allotment,Adults,Childrens,CreatedOn,DepartingDate,ValidityDate,DayOne,DayTwo,DayThree,DayFour,DayFive,DaySix,DaySeven,DayEight,DayNine,DayTen")] TourPackage tourPackage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tourPackage).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tourPackage);
        }

        // GET: Supplier/TourPackages___/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourPackage tourPackage = await db.TourPackages.FindAsync(id);
            if (tourPackage == null)
            {
                return HttpNotFound();
            }
            return View(tourPackage);
        }

        // POST: Supplier/TourPackages___/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TourPackage tourPackage = await db.TourPackages.FindAsync(id);
            db.TourPackages.Remove(tourPackage);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
