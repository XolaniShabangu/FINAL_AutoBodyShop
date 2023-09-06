using FINAL_AutoBodyShop.Models;
using FINAL_AutoBodyShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FINAL_AutoBodyShop.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
       



        public ActionResult CustomerVehicle()
        {
            return View();
        }
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
        public ActionResult Service()
        {
            return View();
        }

        //Towrite to DB


    }
   
}