using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Controllers
{
    public class InventoryController : Controller
    {
        private List<Models.DeviceItem> model = new List<Models.DeviceItem>();

        // GET: DeviceController
        public ActionResult Index()
        {
            if (model == null) model = new List<Models.DeviceItem>();
            return View(model);
        }

        // GET: DeviceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeviceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                model.Add(new Models.DeviceItem { Id = int.Parse(collection["Id"]), DeviceFieldNameId = int.Parse(collection["DeviceFieldNameId"]), DeviceTypeId = int.Parse(collection["DeviceTypeId"]) });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeviceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeviceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeviceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeviceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
