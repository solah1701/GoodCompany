using GoodCompany.Models;
using GoodCompany.Services;
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
        private readonly IPersistence<DeviceItem> devicePersistenceService;
        private readonly IPersistence<DeviceType> deviceTypePersistenceService;
        public InventoryController(
            IPersistence<DeviceItem> devicePersistence,
            IPersistence<DeviceType> deviceTypePersistence
            )
        {
            devicePersistenceService = devicePersistence;
            deviceTypePersistenceService = deviceTypePersistence;
        }

        // GET: DeviceController
        public ActionResult Index()
        {
            return View(devicePersistenceService.Load());
        }

        public ActionResult ComputerIndex()
        {
            return View();
        }

        // GET: DeviceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeviceController/Create
        public ActionResult Create()
        {
            ViewBag.DeviceTypes = deviceTypePersistenceService.Load();
            return View();
        }

        // POST: DeviceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var model = devicePersistenceService.Load();
                devicePersistenceService.Add(new DeviceItem { Id = int.Parse(collection["Id"]), DeviceFieldNameId = int.Parse(collection["DeviceFieldNameId"]), DeviceType = collection["DeviceType"] });
                devicePersistenceService.Save();
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
