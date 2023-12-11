using Katherine_Patino_Arellana.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Katherine_Patino_Arellana.Controllers
{
    public class CiudadController : Controller
    {
        // GET: Ciudad
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ciudad.ToList());
            }
        }

        // GET: Ciudad/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ciudad.Where(x => x.Id == id));
            }
        }

        // GET: Ciudad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ciudad/Create
        [HttpPost]
        public ActionResult Create(Ciudad ciudad)
        {
            try
            {
                // TODO: Add insert logic here

                using (DbModels context = new DbModels())
                {
                    context.Ciudad.Add(ciudad);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudad/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ciudad.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Ciudad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ciudad ciudad)
        {
            try
            {
                // TODO: Add update logic here

                using (DbModels context = new DbModels())
                {
                    context.Entry(ciudad).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudad/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ciudad.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Ciudad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (DbModels contex = new DbModels())
                {
                    Ciudad ciudad = contex.Ciudad.Where(x => x.Id == id).FirstOrDefault();
                    contex.Ciudad.Remove(ciudad);
                    contex.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
