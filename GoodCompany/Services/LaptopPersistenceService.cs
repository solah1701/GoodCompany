using GoodCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public class LaptopPersistenceService : IPersistence<Laptop>
    {
        private readonly List<Laptop> data;

        public LaptopPersistenceService()
        {
            data = new List<Laptop>
            {
                new Laptop
                {
                    Id = 3,
                    ComputerType = "Laptop",
                    Processor = "i7",
                    Brand = "Sony",
                    UsbPorts = 2,
                    RamSlots = 2,
                    FormFactor = "Slim",
                    Quantity = 3,
                    ScreenSize = "Medium"
                }
            };
        }

        public void Add(Laptop item)
        {
            if(data.Exists(i=>i.Id == item.Id)) throw new ArgumentException($"Item Id={item.Id} already exists");
            data.Add(item);
        }

        public void Delete(Laptop item)
        {
            data.Remove(item);
        }

        public void Edit(Laptop item)
        {
            var temp = data.First(i => i.Id == item.Id);
            data.Remove(temp);
            data.Add(item);
        }

        public List<Laptop> Load()
        {
            return data;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
