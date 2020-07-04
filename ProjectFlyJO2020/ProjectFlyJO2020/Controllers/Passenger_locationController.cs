using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectFlyJO2020.Models;

namespace ProjectFlyJO2020.Controllers
{
    public class Passenger_locationController : Controller
    {
        private FlyModel db = new FlyModel();

        // GET: Passenger_location
        public async Task<ActionResult> Index()
        {
            return View(await db.Passenger_location.ToListAsync());
        }

        // GET: Passenger_location/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_location passenger_location = await db.Passenger_location.FindAsync(id);
            if (passenger_location == null)
            {
                return HttpNotFound();
            }
            return View(passenger_location);
        }

        // GET: Passenger_location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passenger_location/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,From,To,Depart,Return")] Passenger_location passenger_location)
        {
            if (ModelState.IsValid)
            {
                db.Passenger_location.Add(passenger_location);
                await db.SaveChangesAsync();
               // return RedirectToAction("Index");
            }

            //return View(passenger_location);
            return RedirectToAction("Create", "Passenger_info");

        }

        // GET: Passenger_location/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_location passenger_location = await db.Passenger_location.FindAsync(id);
            if (passenger_location == null)
            {
                return HttpNotFound();
            }
            return View(passenger_location);
        }

        // POST: Passenger_location/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,From,To,Depart,Return")] Passenger_location passenger_location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenger_location).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(passenger_location);
        }

        // GET: Passenger_location/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_location passenger_location = await db.Passenger_location.FindAsync(id);
            if (passenger_location == null)
            {
                return HttpNotFound();
            }
            return View(passenger_location);
        }

        // POST: Passenger_location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Passenger_location passenger_location = await db.Passenger_location.FindAsync(id);
            db.Passenger_location.Remove(passenger_location);
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
