using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeuPrimeiroProjetoWeb.Models;

namespace MeuPrimeiroProjetoWeb.Controllers
{
    public class TabelaExemplo2Controller : Controller
    {
        private BD_MEUPROJETOWEBEntities db = new BD_MEUPROJETOWEBEntities();

        // GET: TabelaExemplo2
        public ActionResult Index()
        {
            return View(db.TabelaExemplo2.ToList());
        }

        // GET: TabelaExemplo2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaExemplo2 tabelaExemplo2 = db.TabelaExemplo2.Find(id);
            if (tabelaExemplo2 == null)
            {
                return HttpNotFound();
            }
            return View(tabelaExemplo2);
        }

        // GET: TabelaExemplo2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TabelaExemplo2/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nome,email")] TabelaExemplo2 tabelaExemplo2)
        {
            if (ModelState.IsValid)
            {
                db.TabelaExemplo2.Add(tabelaExemplo2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tabelaExemplo2);
        }

        // GET: TabelaExemplo2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaExemplo2 tabelaExemplo2 = db.TabelaExemplo2.Find(id);
            if (tabelaExemplo2 == null)
            {
                return HttpNotFound();
            }
            return View(tabelaExemplo2);
        }

        // POST: TabelaExemplo2/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,email")] TabelaExemplo2 tabelaExemplo2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabelaExemplo2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabelaExemplo2);
        }

        // GET: TabelaExemplo2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaExemplo2 tabelaExemplo2 = db.TabelaExemplo2.Find(id);
            if (tabelaExemplo2 == null)
            {
                return HttpNotFound();
            }
            return View(tabelaExemplo2);
        }

        // POST: TabelaExemplo2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TabelaExemplo2 tabelaExemplo2 = db.TabelaExemplo2.Find(id);
            db.TabelaExemplo2.Remove(tabelaExemplo2);
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
