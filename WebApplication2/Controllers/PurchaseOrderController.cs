using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PurchaseOrderController : Controller
    {
        private WebApplication2MusicStoreDB db = new WebApplication2MusicStoreDB();

        // GET: PurchaseOrder
        public ActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        // GET: PurchaseOrder/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseOrder purchaseOrder = db.Orders.Find(id);
            if (purchaseOrder == null)
            {
                return HttpNotFound();
            }
            return View(purchaseOrder);
        }

        // GET: PurchaseOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseOrder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PurchaseOrderId,PurchaseOrderDate,Username,FirstName,LastName,Address,City,State,PostalCode,Country,Phone,Email,Total")] PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(purchaseOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(purchaseOrder);
        }

        // GET: PurchaseOrder/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseOrder purchaseOrder = db.Orders.Find(id);
            if (purchaseOrder == null)
            {
                return HttpNotFound();
            }
            return View(purchaseOrder);
        }

        // POST: PurchaseOrder/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PurchaseOrderId,PurchaseOrderDate,Username,FirstName,LastName,Address,City,State,PostalCode,Country,Phone,Email,Total")] PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchaseOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(purchaseOrder);
        }

        // GET: PurchaseOrder/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseOrder purchaseOrder = db.Orders.Find(id);
            if (purchaseOrder == null)
            {
                return HttpNotFound();
            }
            return View(purchaseOrder);
        }

        // POST: PurchaseOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PurchaseOrder purchaseOrder = db.Orders.Find(id);
            db.Orders.Remove(purchaseOrder);
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
