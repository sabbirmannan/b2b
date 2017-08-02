//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using PackageBD.Areas.Supplier.Models;
//using PackageBD.DAL;

//namespace PackageBD.Areas.Supplier.Controllers
//{
//    public class SupplierInfoesController : Controller
//    {
//        private PackageDBContext db = new PackageDBContext();

//        // GET: Supplier/SupplierInfoes
//        public ActionResult Index()
//        {
//            var supplierInfos = db.SupplierInfos.Include(s => s.City_sp).Include(s => s.Country).Include(s => s.SupplierUser);
//            return View(supplierInfos.ToList());
//        }

//        // GET: Supplier/SupplierInfoes/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            SupplierInfo supplierInfo = db.SupplierInfos.Find(id);
//            if (supplierInfo == null)
//            {
//                return HttpNotFound();
//            }
//            return View(supplierInfo);
//        }

//        // GET: Supplier/SupplierInfoes/Create
//        public ActionResult Create()
//        {
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName");
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName");
//            ViewBag.SupplierID = new SelectList(db.ApplicationUsers, "Id", "Email");
//            return View();
//        }

//        // POST: Supplier/SupplierInfoes/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "SupplierID,SupplierCode,SupplierName,SupplierVoucherName,SupplerAddress,Postcode,Telephone,Fax,Mobile,SupEmail,CountryId,CityID,TimeZone,PreferredCurrency,SrviceType,FirstName,MiddleName,LastName,ContactEmail,ContactPerson1,ContactPerson2,ReservationEmail,CancellationEmail,ModificationEmail,TechnicalEmail,Activation")] SupplierInfo supplierInfo)
//        {
//            if (ModelState.IsValid)
//            {
//                db.SupplierInfos.Add(supplierInfo);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", supplierInfo.CityID);
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName", supplierInfo.CountryId);
//            ViewBag.SupplierID = new SelectList(db.ApplicationUsers, "Id", "Email", supplierInfo.SupplierID);
//            return View(supplierInfo);
//        }

//        // GET: Supplier/SupplierInfoes/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            SupplierInfo supplierInfo = db.SupplierInfos.Find(id);
//            if (supplierInfo == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", supplierInfo.CityID);
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName", supplierInfo.CountryId);
//            ViewBag.SupplierID = new SelectList(db.ApplicationUsers, "Id", "Email", supplierInfo.SupplierID);
//            return View(supplierInfo);
//        }

//        // POST: Supplier/SupplierInfoes/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "SupplierID,SupplierCode,SupplierName,SupplierVoucherName,SupplerAddress,Postcode,Telephone,Fax,Mobile,SupEmail,CountryId,CityID,TimeZone,PreferredCurrency,SrviceType,FirstName,MiddleName,LastName,ContactEmail,ContactPerson1,ContactPerson2,ReservationEmail,CancellationEmail,ModificationEmail,TechnicalEmail,Activation")] SupplierInfo supplierInfo)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(supplierInfo).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", supplierInfo.CityID);
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName", supplierInfo.CountryId);
//            ViewBag.SupplierID = new SelectList(db.ApplicationUsers, "Id", "Email", supplierInfo.SupplierID);
//            return View(supplierInfo);
//        }

//        // GET: Supplier/SupplierInfoes/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            SupplierInfo supplierInfo = db.SupplierInfos.Find(id);
//            if (supplierInfo == null)
//            {
//                return HttpNotFound();
//            }
//            return View(supplierInfo);
//        }

//        // POST: Supplier/SupplierInfoes/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            SupplierInfo supplierInfo = db.SupplierInfos.Find(id);
//            db.SupplierInfos.Remove(supplierInfo);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
