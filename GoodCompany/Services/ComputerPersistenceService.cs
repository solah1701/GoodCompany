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
            data = new List<Computer>();
        }


        public void Add(Computer item)
        {
            if (data.Exists(i => i.Id == item.Id)) throw new ArgumentException($"Item Id={item.Id} already exists");
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
