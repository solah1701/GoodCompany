using GoodCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public class ComputerPersistenceService : IPersistence<Computer>
    {
        private readonly List<Computer> data;

        public ComputerPersistenceService()
        {
            data = new List<Computer>
            {
                new Computer
                {
                    Id = 1,
                    ComputerType = "Desktop PC",
                    Processor = "i7",
                    Brand = "Hewlett Packard",
                    UsbPorts = 6,
                    RamSlots = 2,
                    FormFactor = "Slim",
                    Quantity = 3
                },
                new Computer
                {
                    Id = 2,
                    ComputerType = "Desktop PC",
                    Processor = "i5",
                    Brand = "Dell",
                    UsbPorts = 2,
                    RamSlots = 3,
                    FormFactor = "Maxi",
                    Quantity = 6
                }
            };
        }


        public void Add(Computer item)
        {
            if (data.Exists(i => i.Id == item.Id)) throw new ArgumentException($"Item Id={item.Id} already exists");
            data.Add(item);
        }

        public void Delete(Computer item)
        {
            data.Remove(item);
        }

        public void Edit(Computer item)
        {
            var temp = data.First(i => i.Id == item.Id);
            data.Remove(temp);
            data.Add(item);
        }

        public List<Computer> Load()
        {
            return data;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
