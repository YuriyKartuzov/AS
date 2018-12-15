using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActorStudio.Controllers
{
    [Authorize(Roles = "Admin,Student,Developer" )]
    public class VocalController : Controller
    {
        Manager m = new Manager();

        // GET: Vocal
        public ActionResult Index()
        {
            var o = m.VocalGetAll();
            return View(o);
        }

        // GET: Vocal/Details/5
        public ActionResult Details(int id)
        {
            var o = m.VocalGetOne(id);
            return View(o);
        }


        // GET: Vocal/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            var newItem = new VocalAddForm();
            return View(newItem);
        }

        // POST: Vocal/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(VocalAdd newItem)
        {

            if (!ModelState.IsValid)
                return RedirectToAction("index");

            var addedItem = m.VocalAddNew(newItem);

            if (addedItem == null)
                return View(newItem);
            else
                return RedirectToAction("details", new { id = addedItem.Id });
        }

        // GET: Vocal/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var o = m.VocalGetOne(id);

            if (o == null)
                return HttpNotFound();
            else
            {
                var editForm = m.mapper.Map<VocalEditForm>(o);
                return View(editForm);
            }
        }

        // POST: Vocal/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id, VocalEditForm newItem)
        {

            if (!ModelState.IsValid)
                return RedirectToAction("edit", new { id = newItem.Id });

            if (id.GetValueOrDefault() != newItem.Id)
            {
                return RedirectToAction("index");
            }

            var editedItem = m.VocalEditForm(newItem);

            if (editedItem == null)
                return RedirectToAction("edit", new { id = newItem.Id });
            else
                return RedirectToAction("details", new { id = newItem.Id });

        }

        // GET: Vocal/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            var item = m.mapper.Map<VocalDeleteForm>( m.VocalGetOne(id.GetValueOrDefault()) );

            if (item == null)
                return RedirectToAction("index");
            else
                return View(item);
        }

        // POST: Vocal/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            var result = m.VocalDelete(id.GetValueOrDefault());
            return RedirectToAction("index");
        }

    }
}
