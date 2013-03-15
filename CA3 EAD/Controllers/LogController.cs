using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA3_EAD.Models;

namespace CA3_EAD.Controllers
{
    public class LogController : Controller
    {
        private EmployeeDatabase db = new EmployeeDatabase();

        //
        // GET: /Log/

        public ActionResult Index()
        {
            var logs = db.Logs.Include("Employee");
            return View(logs.ToList());
        }

        //
        // GET: /Log/Details/5

        public ActionResult Details(int id = 0)
        {
            Log log = db.Logs.Single(l => l.LogId == id);
            if (log == null)
            {
                return HttpNotFound();
            }
            return View(log);
        }

        //
        // GET: /Log/Create

        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name");
            return View();
        }

        //
        // POST: /Log/Create

        [HttpPost]
        public ActionResult Create(Log log)
        {
            if (ModelState.IsValid)
            {
                db.Logs.AddObject(log);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", log.EmployeeId);
            return View(log);
        }

        //
        // GET: /Log/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Log log = db.Logs.Single(l => l.LogId == id);
            if (log == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", log.EmployeeId);
            return View(log);
        }

        //
        // POST: /Log/Edit/5

        [HttpPost]
        public ActionResult Edit(Log log)
        {
            if (ModelState.IsValid)
            {
                db.Logs.Attach(log);
                db.ObjectStateManager.ChangeObjectState(log, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", log.EmployeeId);
            return View(log);
        }

        //
        // GET: /Log/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Log log = db.Logs.Single(l => l.LogId == id);
            if (log == null)
            {
                return HttpNotFound();
            }
            return View(log);
        }

        //
        // POST: /Log/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Log log = db.Logs.Single(l => l.LogId == id);
            db.Logs.DeleteObject(log);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}