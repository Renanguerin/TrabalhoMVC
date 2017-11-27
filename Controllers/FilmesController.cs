using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using MVC.Model;

namespace MVC.Controllers
{
    public class FilmesController : Controller
    {
        Contexto contexto = new Contexto();

        // GET: Filmes
        public ActionResult Index()
        {
            List<Filme> lstFilme = contexto.Filmes.ToList();
            return View(lstFilme);
        }

        //get: Filmes/Create
        public ActionResult Create()
        {
            return View();
        }

         //post: Filme/Create
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Create([Bind(Include ="id, descricao, sinopse, quantidade")] Filme filme)
     
        {
            if (ModelState.IsValid)
            {
                contexto.Filmes.Add(filme);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View(filme);
        }

        //get: Filmes/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                Filme filme = contexto.Filmes.Find(id);
            if (filme == null)
                return HttpNotFound();
            return View(filme);

            
        }

        //Post: //Filmes/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id, descricao, sinopse, quantidade")] Filme filme)
        {
            if (ModelState.IsValid)
            {
                contexto.Entry(filme).State = EntityState.Modified;
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View(filme);
        }

        //get: Filmes/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Filme filme = contexto.Filmes.Find(id);
            if (filme == null)
                return HttpNotFound();
            return View(filme);


        }

        //GET: //Filmes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Filme filme = contexto.Filmes.Find(id);
            if (filme == null)
                return HttpNotFound();
            return View(filme);

        }

        //Post: //Filmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCofirme(int id)
        {
            Filme filme = contexto.Filmes.Find(id);
            contexto.Filmes.Remove(filme);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                contexto.Dispose();
            base.Dispose(disposing);
        }
    }
}