using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FINAL_AutoBodyShop.Models;
using FINAL_AutoBodyShop.Models.Data;

namespace FINAL_AutoBodyShop.Controllers
{
    public class CustomerVehiclesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CustomerVehicles
        public ActionResult Index()
        {
            return View(db.CustomerVehicle.ToList());
        }

        // GET: CustomerVehicles/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerVehicle customerVehicle = db.CustomerVehicle.Find(id);
            if (customerVehicle == null)
            {
                return HttpNotFound();
            }
            return View(customerVehicle);
        }

        // GET: CustomerVehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerVehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Number_Plate,Vehicle_Name,Car_Model,Year,Current_Mileage,Engine_Type,Service_History")] CustomerVehicle customerVehicle)
        {
            if (ModelState.IsValid)
            {
                db.CustomerVehicle.Add(customerVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerVehicle);
        }

        // GET: CustomerVehicles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerVehicle customerVehicle = db.CustomerVehicle.Find(id);
            if (customerVehicle == null)
            {
                return HttpNotFound();
            }
            return View(customerVehicle);
        }

        // POST: CustomerVehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Number_Plate,Vehicle_Name,Car_Model,Year,Current_Mileage,Engine_Type,Service_History")] CustomerVehicle customerVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerVehicle);
        }

        // GET: CustomerVehicles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerVehicle customerVehicle = db.CustomerVehicle.Find(id);
            if (customerVehicle == null)
            {
                return HttpNotFound();
            }
            return View(customerVehicle);
        }

        // POST: CustomerVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CustomerVehicle customerVehicle = db.CustomerVehicle.Find(id);
            db.CustomerVehicle.Remove(customerVehicle);
            db.SaveChanges();
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
