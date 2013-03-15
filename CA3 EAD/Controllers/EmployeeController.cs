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
    public class EmployeeController : Controller
    {
        private EmployeeDatabase db = new EmployeeDatabase();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var employees = db.Employees.Include("CompanyPosition");
            return View(employees.ToList());
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Single(e => e.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            ViewBag.GradeID = new SelectList(db.CompanyPositions, "GradeID", "JobDescription");
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.AddObject(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradeID = new SelectList(db.CompanyPositions, "GradeID", "JobDescription", employee.GradeID);
            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Single(e => e.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradeID = new SelectList(db.CompanyPositions, "GradeID", "JobDescription", employee.GradeID);
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Attach(employee);
                db.ObjectStateManager.ChangeObjectState(employee, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GradeID = new SelectList(db.CompanyPositions, "GradeID", "JobDescription", employee.GradeID);
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Single(e => e.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Single(e => e.EmployeeId == id);
            db.Employees.DeleteObject(employee);
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