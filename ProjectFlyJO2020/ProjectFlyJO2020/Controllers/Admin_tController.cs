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
    public class Admin_tController : Controller
    {
        private FlyModel db = new FlyModel();

        // GET: Admin_t
        public async Task<ActionResult> Index()
        {
            return View(await db.Admin_t.ToListAsync());
        }

        // GET: Admin_t/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_t admin_t = await db.Admin_t.FindAsync(id);
            if (admin_t == null)
            {
                return HttpNotFound();
            }
            return View(admin_t);
        }

        // GET: Admin_t/Create
        public ActionResult Create()
        {
            return View();
        }

       
        // POST: Admin_t/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,username,password")] Admin_t admin_t)
        {
            if (ModelState.IsValid)
            {
                db.Admin_t.Add(admin_t);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(admin_t);
        }

        // GET: Admin_t/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_t admin_t = await db.Admin_t.FindAsync(id);
            if (admin_t == null)
            {
                return HttpNotFound();
            }
            return View(admin_t);
        }

        // POST: Admin_t/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,username,password")] Admin_t admin_t)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin_t).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(admin_t);
        }

        // GET: Admin_t/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_t admin_t = await db.Admin_t.FindAsync(id);
            if (admin_t == null)
            {
                return HttpNotFound();
            }
            return View(admin_t);
        }
    
        public ActionResult login(Admin_t admin)
        {
            var adm = db.Admin_t.FirstOrDefault(d => d.username.Equals(admin.username) && d.password.Equals(admin.password));
           
            if (adm != null && ModelState.IsValid)
            {
                return RedirectToAction("Index", "passenger_info");
            }
           
            return View();
        }
        // POST: Admin_t/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Admin_t admin_t = await db.Admin_t.FindAsync(id);
            db.Admin_t.Remove(admin_t);
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
