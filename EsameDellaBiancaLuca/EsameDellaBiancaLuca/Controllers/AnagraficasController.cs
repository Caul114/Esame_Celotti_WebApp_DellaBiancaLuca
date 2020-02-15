using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EsameDellaBiancaLuca.Models;

namespace EsameDellaBiancaLuca.Controllers
{
    public class AnagraficasController : Controller
    {
        private Model1 db = new Model1();

        // GET: Anagraficas
        public ActionResult Index()
        {
            return View(db.Anagrafica.ToList());
        }

        // GET: Anagraficas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.Anagrafica.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // GET: Anagraficas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anagraficas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnagraficaId,Cognome,Nome,Email,Telefono,Cliente,Interno,Fornitore,CodiceAnagrafica,Username,Password")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                db.Anagrafica.Add(anagrafica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anagrafica);
        }

        // GET: Anagraficas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.Anagrafica.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // POST: Anagraficas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnagraficaId,Cognome,Nome,Email,Telefono,Cliente,Interno,Fornitore,CodiceAnagrafica,Username,Password")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anagrafica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anagrafica);
        }

        // GET: Anagraficas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.Anagrafica.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // POST: Anagraficas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anagrafica anagrafica = db.Anagrafica.Find(id);
            db.Anagrafica.Remove(anagrafica);
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
