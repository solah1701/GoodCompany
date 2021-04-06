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
            var model = new List<Computer>();
            model.AddRange(computerPersistenceService.Load());
            model.AddRange(laptopPersistenceService.Load());
            return View(model);
        }

        // GET: DeviceController/Details/5
        public ActionResult Details(int id)
        {
            if (computerPersistenceService.Load().Exists(item => item.Id == id))
            {
                var computerModel = computerPersistenceService.Load().First(item => item.Id == id);
                return View(computerModel);
            }
            var laptopModel = laptopPersistenceService.Load().First(item => item.Id == id);
            return View(laptopModel);
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
                if (collection["ComputerType"] == "Desktop PC")
                {
                    var model = computerPersistenceService.Load();
                    computerPersistenceService.Add(new Computer
                    {
                        Id = int.Parse(collection["Id"]),
                        ComputerType = collection["ComputerType"],
                        Processor = collection["Processor"],
                        Brand = collection["Brand"],
                        UsbPorts = int.Parse(collection["UsbPorts"]),
                        RamSlots = int.Parse(collection["RamSlots"]),
                        FormFactor = collection["FormFactor"],
                        Quantity = int.Parse(collection["Quantity"])
                    });
                }
                else
                {
                    var model = laptopPersistenceService.Load();
                    laptopPersistenceService.Add(new Laptop
                    {
                        Id = int.Parse(collection["Id"]),
                        ComputerType = collection["ComputerType"],
                        Processor = collection["Processor"],
                        Brand = collection["Brand"],
                        UsbPorts = int.Parse(collection["UsbPorts"]),
                        RamSlots = int.Parse(collection["RamSlots"]),
                        FormFactor = collection["FormFactor"],
                        Quantity = int.Parse(collection["Quantity"]),
                        ScreenSize = collection["ScreenSize"]
                    });
                }
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
            if (computerPersistenceService.Load().Exists(item => item.Id == id))
            {
                var computerModel = computerPersistenceService.Load().First(item => item.Id == id);
                return View(computerModel);
            }
            var laptopModel = laptopPersistenceService.Load().First(item => item.Id == id);
            return View(laptopModel);
        }

        // POST: DeviceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (collection["ComputerType"] == "Desktop PC")
                {
                    computerPersistenceService.Edit(
                      new Computer
                      {
                          Id = int.Parse(collection["Id"]),
                          ComputerType = collection["ComputerType"],
                          Processor = collection["Processor"],
                          Brand = collection["Brand"],
                          UsbPorts = int.Parse(collection["UsbPorts"]),
                          RamSlots = int.Parse(collection["RamSlots"]),
                          FormFactor = collection["FormFactor"],
                          Quantity = int.Parse(collection["Quantity"])
                      });
                }
                else
                {
                    laptopPersistenceService.Edit(
                      new Laptop
                      {
                          Id = int.Parse(collection["Id"]),
                          ComputerType = collection["ComputerType"],
                          Processor = collection["Processor"],
                          Brand = collection["Brand"],
                          UsbPorts = int.Parse(collection["UsbPorts"]),
                          RamSlots = int.Parse(collection["RamSlots"]),
                          FormFactor = collection["FormFactor"],
                          Quantity = int.Parse(collection["Quantity"]),
                          ScreenSize = collection["ScreenSize"]
                      });

                }
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
            if (computerPersistenceService.Load().Exists(item => item.Id == id))
            {
                var computerModel = computerPersistenceService.Load().First(item => item.Id == id);
                return View(computerModel);
            }
            var laptopModel = laptopPersistenceService.Load().First(item => item.Id == id);
            return View(laptopModel);
        }

        // POST: DeviceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var temp = computerPersistenceService.Load().First(item => item.Id == id);
                if (temp != null)
                { 
                    computerPersistenceService.Delete(temp); 
                }
                else
                {
                    var temp1 = laptopPersistenceService.Load().First(item => item.Id == id);
                    laptopPersistenceService.Delete(temp1);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
