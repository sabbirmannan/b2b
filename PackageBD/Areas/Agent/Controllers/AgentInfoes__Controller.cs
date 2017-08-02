//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using PackageBD.Areas.Agent.Models;
//using PackageBD.DAL;

//namespace PackageBD.Areas.Agent.Controllers
//{
//    public class AgentInfoes__Controller : Controller
//    {
//        private PackageDBContext db = new PackageDBContext();

//        // GET: Agent/AgentInfoes__
//        public ActionResult Index()
//        {
//            var agentInfos = db.AgentInfos.Include(a => a.AgentUser).Include(a => a.City_ag).Include(a => a.Country);
//            return View(agentInfos.ToList());
//        }

//        // GET: Agent/AgentInfoes__/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            AgentInfo agentInfo = db.AgentInfos.Find(id);
//            if (agentInfo == null)
//            {
//                return HttpNotFound();
//            }
//            return View(agentInfo);
//        }

//        // GET: Agent/AgentInfoes__/Create
//        public ActionResult Create()
//        {
//            ViewBag.AgentInfoID = new SelectList(db.ApplicationUsers, "Id", "Email");
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName");
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName");
//            return View();
//        }

//        // POST: Agent/AgentInfoes__/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "AgentInfoID,AgentCode,AgencyName,AgencyEmail,FirstName,LastName,Designation,IATAStatus,NatureOfBusiness,BusinessType,HearBy,PreferredCurrency,Address,PostCode,Telephone,Mobile,Fax,CountryId,CityID,TimeZone,Website,LogoPath,Name,Email,Number,Activation")] AgentInfo agentInfo)
//        {
//            if (ModelState.IsValid)
//            {
//                db.AgentInfos.Add(agentInfo);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.AgentInfoID = new SelectList(db.ApplicationUsers, "Id", "Email", agentInfo.AgentInfoID);
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", agentInfo.CityID);
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName", agentInfo.CountryId);
//            return View(agentInfo);
//        }

//        // GET: Agent/AgentInfoes__/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            AgentInfo agentInfo = db.AgentInfos.Find(id);
//            if (agentInfo == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.AgentInfoID = new SelectList(db.ApplicationUsers, "Id", "Email", agentInfo.AgentInfoID);
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", agentInfo.CityID);
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName", agentInfo.CountryId);
//            return View(agentInfo);
//        }

//        // POST: Agent/AgentInfoes__/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "AgentInfoID,AgentCode,AgencyName,AgencyEmail,FirstName,LastName,Designation,IATAStatus,NatureOfBusiness,BusinessType,HearBy,PreferredCurrency,Address,PostCode,Telephone,Mobile,Fax,CountryId,CityID,TimeZone,Website,LogoPath,Name,Email,Number,Activation")] AgentInfo agentInfo)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(agentInfo).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.AgentInfoID = new SelectList(db.ApplicationUsers, "Id", "Email", agentInfo.AgentInfoID);
//            ViewBag.CityID = new SelectList(db.Cities, "CityID", "CityName", agentInfo.CityID);
//            ViewBag.CountryId = new SelectList(db.Countries, "CountryID", "CountryName", agentInfo.CountryId);
//            return View(agentInfo);
//        }

//        // GET: Agent/AgentInfoes__/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            AgentInfo agentInfo = db.AgentInfos.Find(id);
//            if (agentInfo == null)
//            {
//                return HttpNotFound();
//            }
//            return View(agentInfo);
//        }

//        // POST: Agent/AgentInfoes__/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            AgentInfo agentInfo = db.AgentInfos.Find(id);
//            db.AgentInfos.Remove(agentInfo);
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
