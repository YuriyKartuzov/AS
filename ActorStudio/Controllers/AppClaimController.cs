using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActorStudio.Controllers
{
    public class AppClaimController : Controller
    {
        // GET: AppClaim
        public ActionResult Index()
        {
            return View();
        }

        // GET: AppClaim/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppClaim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppClaim/Create
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

        // GET: AppClaim/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppClaim/Edit/5
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

        // GET: AppClaim/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppClaim/Delete/5
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
