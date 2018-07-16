using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stand.Models;

namespace Stand.Controllers
{
    public class StandsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Stands
        public ActionResult Index()
        {
            var listaStands = db.Stands.ToList().OrderBy(a => a.Nome);

            return View(listaStands);
          
        }

        // GET: Stands/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stands stands = db.Stands.Find(id);
            if (stands == null)
            {
                return HttpNotFound();
            }
            return View(stands);
        }

        // GET: Stands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Telefone,CodigoPostal,Email,Localizacao,Zona,Imagens")] Stands stands,HttpPostedFileBase fileUploadFoto)
        {
            if (ModelState.IsValid)
            {
                db.Stands.Add(stands);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stands);
        }

        // GET: Stands/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stands stands = db.Stands.Find(id);
            if (stands == null)
            {
                return HttpNotFound();
            }
            return View(stands);
        }

        // POST: Stands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Telefone,CodigoPostal,Email,Localizacao,Zona")] Stands stands)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stands).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stands);
        }

        // GET: Stands/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stands stands = db.Stands.Find(id);
            if (stands == null)
            {
                return HttpNotFound();
            }
            return View(stands);
        }

        // POST: Stands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stands stands = db.Stands.Find(id);
            db.Stands.Remove(stands);
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
