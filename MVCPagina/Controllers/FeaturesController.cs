using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCPagina.Models;
using AutoMapper;

namespace MVCPagina.Controllers
{
    public class FeaturesController : Controller
    {
        private SolutionsDB db = new SolutionsDB();

        // GET: Features
        public ActionResult Index(int? id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFeature([Bind(Include = "Nombre")] FeatureViewModel featureVM)
        {

            Mapper.CreateMap<FeatureViewModel, Feature>();


            Feature feature = Mapper.Map<Feature>(featureVM);
            //var servicio = db.Servicios.Find(id);

            //if (servicio != null)
            //{
            //    var feature1 = new Feature { Nombre = feature };
            //    var servicioFeature = new ServicioFeature
            //    {
            //        Servicio = servicio,
            //        Feature = feature1,
            //    };

            //    db.ServicioFeatures.Add(servicioFeature);
            //    db.SaveChanges();
            //}
            if (ModelState.IsValid)
            {
                db.Features.Add(feature);
                db.SaveChanges();
            }

            //var features = servicio.ServicioFeatures.Select(mc => mc.Feature).OrderBy(x => x.FeatureId);
            //var features = db.Features;
            return Details();
        }

        // GET: Features/Details/servicioId=5
        public ActionResult Details()
        {
            //if (servicioId == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //var servicio = db.Servicios.Find(servicioId);
            //if (servicio == null)
            //{
            //    return HttpNotFound();
            //}

            //var features = servicio.ServicioFeatures.Select(mc => mc.Feature).OrderBy(x => x.FeatureId);
            return PartialView("Features", db.Features);
        }

        // GET: Features/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Features/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeatureId,Nombre")] Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Features.Add(feature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(feature);
        }

        // GET: Features/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // POST: Features/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeatureId,Nombre")] Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feature);
        }

        // GET: Features/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // POST: Features/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Feature feature = db.Features.Find(id);
            db.Features.Remove(feature);
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
