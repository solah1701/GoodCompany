using GoodCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public class DeviceTypePersistanceService : IPersistence<DeviceType>
    {
        private readonly List<DeviceType> data;

        public DeviceTypePersistanceService()
        {
            data = new List<DeviceType>
            {
                new DeviceType { Name = "Desktop PC" },
                new DeviceType { Name = "Laptop" }
            };
        }
        public void Add(DeviceType item)
        {
            throw new NotImplementedException();
        }

        public List<DeviceType> Load()
        {
            return data;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
