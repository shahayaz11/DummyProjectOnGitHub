using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyProjectOnGitHub.Controllers
{
    public class ggController : Controller
    {
        // GET: gg
        public ActionResult Index()
        {
            return View();
        }

        // GET: gg/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: gg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gg/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: gg/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: gg/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: gg/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: gg/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
