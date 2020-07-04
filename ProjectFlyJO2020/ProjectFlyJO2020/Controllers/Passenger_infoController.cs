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
    public class Passenger_infoController : Controller
    {
        private FlyModel db = new FlyModel();

        // GET: Passenger_info
        public async Task<ActionResult> Index()
        {
            return View(await db.Passenger_info.ToListAsync());
        }

        // GET: Passenger_info/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_info passenger_info = await db.Passenger_info.FindAsync(id);
            if (passenger_info == null)
            {
                return HttpNotFound();
            }


            Passenger_location passenger_location = await db.Passenger_location.FindAsync(id);
            var second = new Passenger_location { From = passenger_location.From, To = passenger_location.To, Depart = passenger_location.Depart, Return = passenger_location.Return };
            var first = new Passenger_info
            {
                Id = passenger_info.Id,
                Fname = passenger_info.Fname,
                Lname = passenger_info.Lname,
                Adult = passenger_info.Adult
            ,
                Elders = passenger_info.Elders,
                Kids = passenger_info.Kids,
                Phone = passenger_info.Phone
            };
        
            ViewBag.Total = new List<int>()
            {
               
               passenger_info.Kids*30 +passenger_info.Adult*50 +passenger_info.Elders*35
            };
            ViewBag.NO = new List<int>()
            {

               passenger_info.Kids +passenger_info.Adult +passenger_info.Elders
            };

            var tupleData = new Tuple<Passenger_info, Passenger_location>(first, second);
            return View(tupleData);
        }

        // GET: Passenger_info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passenger_info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Fname,Lname,Kids,Adult,Elders,Phone")] Passenger_info passenger_info)
        {
            if (ModelState.IsValid)
            {
                db.Passenger_info.Add(passenger_info);
                await db.SaveChangesAsync();
                return RedirectToAction("Details", new { @id = passenger_info.Id });
            }

            return View();
        }

        // GET: Passenger_info/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_info passenger_info = await db.Passenger_info.FindAsync(id);
            if (passenger_info == null)
            {
                return HttpNotFound();
            }
            return View(passenger_info);
        }

        // POST: Passenger_info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Fname,Lname,Kids,Adult,Elders,Phone")] Passenger_info passenger_info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenger_info).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(passenger_info);
        }

        // GET: Passenger_info/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_info passenger_info = await db.Passenger_info.FindAsync(id);
            if (passenger_info == null)
            {
                return HttpNotFound();
            }
            return View(passenger_info);
        }

        // POST: Passenger_info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Passenger_info passenger_info = await db.Passenger_info.FindAsync(id);
            db.Passenger_info.Remove(passenger_info);
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
