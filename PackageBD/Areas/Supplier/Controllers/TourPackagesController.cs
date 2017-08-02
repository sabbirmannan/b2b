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
using System.IO;

namespace PackageBD.Areas.Supplier.Controllers
{
    public class TourPackagesController : Controller
    {
        private PackageDBContext db = new PackageDBContext();

        // GET: Supplier/TourPackages
        public async Task<ActionResult> Index()
        {
            return View(await db.TourPackages.ToListAsync());
        }

        // GET: Supplier/TourPackages/Details/5
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

        // GET: Supplier/TourPackages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/TourPackages/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TourPackageID,TourPackageTitle,Highlights,InclusionExclusion,TourDestination,SpecialNotes,TourCostPrice,TourSalesPrice,TourDiscountPrice,TotalNights,HotelStar,HotelInUse,DayWiseItienary,TearmsAndConditions,Allotment,Adults,Childrens,CreatedOn,DepartingDate,ValidityDate,DayOne,DayTwo,DayThree,DayFour,DayFive,DaySix,DaySeven,DayEight,DayNine,DayTen")] TourPackage tourPackage)
        {
            if (ModelState.IsValid)
            {
                List<FileDetail> fileDetails = new List<FileDetail>();
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];

                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        FileDetail fileDetail = new FileDetail()
                        {
                            FileName = fileName,
                            Extension = Path.GetExtension(fileName),
                            FileDetailsId = Guid.NewGuid()
                        };
                        fileDetails.Add(fileDetail);

                        var path = Path.Combine(Server.MapPath("~/Images/packageImg/"), fileDetail.FileDetailsId + fileDetail.Extension);
                        file.SaveAs(path);
                    }
                }
                tourPackage.FileDetails = fileDetails;
                db.TourPackages.Add(tourPackage);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tourPackage);
        }

        // GET: Supplier/TourPackages/Edit/5
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

        // POST: Supplier/TourPackages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TourPackageID,TourPackageTitle,Highlights,InclusionExclusion,TourDestination,SpecialNotes,TourCostPrice,TourSalesPrice,TourDiscountPrice,TotalNights,HotelStar,HotelInUse,DayWiseItienary,TearmsAndConditions,Allotment,Adults,Childrens,CreatedOn,DepartingDate,ValidityDate,DayOne,DayTwo,DayThree,DayFour,DayFive,DaySix,DaySeven,DayEight,DayNine,DayTen")] TourPackage tourPackage)
        {
            if (ModelState.IsValid)
            {
                //New Files
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];

                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        FileDetail fileDetail = new FileDetail()
                        {
                            FileName = fileName,
                            Extension = Path.GetExtension(fileName),
                            FileDetailsId = Guid.NewGuid(),
                            TourPackageId = tourPackage.TourPackageID
                        };
                        var path = Path.Combine(Server.MapPath("~/Images/packageImg/"), fileDetail.FileDetailsId + fileDetail.Extension);
                        file.SaveAs(path);
                        db.Entry(fileDetail).State = EntityState.Added;
                    }
                }
              
                //tourPackage.ModifiedOn = DateTime.Now;
                db.Entry(tourPackage).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tourPackage);
        }

        #region Delete file
        [HttpPost]
        public JsonResult DeleteFile(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Result = "Error" });
            }
            try
            {
                Guid guid = new Guid(id);
                FileDetail fileDetail = db.FileDetail.Find(guid);
                if (fileDetail == null)
                {
                    Response.StatusCode = (int)HttpStatusCode.NotFound;
                    return Json(new { Result = "Error" });
                }

                //Remove from database
                db.FileDetail.Remove(fileDetail);
                db.SaveChanges();

                //Delete file from the file system
                var path = Path.Combine(Server.MapPath("~/Images/packageImg/"), fileDetail.FileDetailsId + fileDetail.Extension);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        //
        // POST: /Support/Delete/5

        [HttpPost]
        public JsonResult Delete(int id)
        {
            try
            {
                TourPackage tourpackage = db.TourPackages.Find(id);
                if (tourpackage == null)
                {
                    Response.StatusCode = (int)HttpStatusCode.NotFound;
                    return Json(new { Result = "Error" });
                }

                //delete files from the file system

                foreach (var item in tourpackage.FileDetails)
                {
                    String path = Path.Combine(Server.MapPath("~/Images/packageImg/"), item.FileDetailsId + item.Extension);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }

                db.TourPackages.Remove(tourpackage);
                db.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        #endregion


        // GET: Supplier/TourPackages/Delete/5
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

        // POST: Supplier/TourPackages/Delete/5
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
