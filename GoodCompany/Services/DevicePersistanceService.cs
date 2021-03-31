using GoodCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public class DevicePersistanceService : IPersistence<DeviceItem>
    {
        private readonly List<DeviceItem> data;

        public DevicePersistanceService()
        {
            data = new List<DeviceItem>();
        }
        public List<DeviceItem> Load()
        {
            return data;
        }

        public void Add(DeviceItem item)
        {
            if (data.Exists(x => x.Id == item.Id)) throw new ArgumentException("Id already exists");
            data.Add(item);
        }

        public void Save()
        {

        }
    }
}
