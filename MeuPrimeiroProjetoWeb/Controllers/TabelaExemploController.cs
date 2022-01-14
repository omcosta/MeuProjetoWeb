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
    public class TabelaExemploController : Controller
    {
        private BD_MEUPROJETOWEBEntities db = new BD_MEUPROJETOWEBEntities();

        // GET: TabelaExemplo
        public ActionResult Index()
        {
            return View(db.TabelaExemplo.ToList());
        }

        // GET: TabelaExemplo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaExemplo tabelaExemplo = db.TabelaExemplo.Find(id);
            if (tabelaExemplo == null)
            {
                return HttpNotFound();
            }
            return View(tabelaExemplo);
        }

        // GET: TabelaExemplo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TabelaExemplo/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] TabelaExemplo tabelaExemplo)
        {
            if (ModelState.IsValid)
            {
                db.TabelaExemplo.Add(tabelaExemplo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tabelaExemplo);
        }

        // GET: TabelaExemplo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaExemplo tabelaExemplo = db.TabelaExemplo.Find(id);
            if (tabelaExemplo == null)
            {
                return HttpNotFound();
            }
            return View(tabelaExemplo);
        }

        // POST: TabelaExemplo/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] TabelaExemplo tabelaExemplo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabelaExemplo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabelaExemplo);
        }

        // GET: TabelaExemplo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaExemplo tabelaExemplo = db.TabelaExemplo.Find(id);
            if (tabelaExemplo == null)
            {
                return HttpNotFound();
            }
            return View(tabelaExemplo);
        }

        // POST: TabelaExemplo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TabelaExemplo tabelaExemplo = db.TabelaExemplo.Find(id);
            db.TabelaExemplo.Remove(tabelaExemplo);
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
