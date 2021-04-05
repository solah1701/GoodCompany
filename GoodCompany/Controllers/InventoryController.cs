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
        private readonly IPersistence<Computer> computerPersistenceService;
        private readonly IPersistence<Laptop> laptopPersistenceService;

        public InventoryController(
            IPersistence<Computer> computerPersistence,
            IPersistence<Laptop> laptopPersistence
            )
        {
            computerPersistenceService = computerPersistence;
            laptopPersistenceService = laptopPersistence;
        }

        // GET: DeviceController
        public ActionResult Index()
        {
            return View(computerPersistenceService.Load());
        }

        // GET: DeviceController/Details/5
        public ActionResult Details(int id)
        {
            return View(computerPersistenceService.Load().First(item => item.Id == id));
        }

        // GET: DeviceController/Create
        public ActionResult Create()
        {
            ViewBag.DeviceTypes = new List<string>
            {
                "Desktop PC",
                "Laptop"
            };
            return View();
        }

        // POST: DeviceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var model = computerPersistenceService.Load();
                computerPersistenceService.Add(new Computer { 
                    Id = int.Parse(collection["Id"]), 
                    ComputerType = collection["ComputerType"] ,
                    Processor = collection["Processor"],
                    Brand = collection["Brand"],
                    UsbPorts = int.Parse(collection["UsbPorts"]),
                    RamSlots = int.Parse(collection["RamSlots"]),
                    FormFactor = collection["FormFactor"],
                    Quantity = int.Parse(collection["Quantity"])
                });
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
