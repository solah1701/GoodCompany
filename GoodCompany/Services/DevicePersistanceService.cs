using GoodCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public class DevicePersistanceService : IPersistence<DeviceItem>
    {
        private List<DeviceItem> data;

        public DevicePersistanceService()
        {
            data = new List<DeviceItem>();
        }
        public List<DeviceItem> Load()
        {
            return data;
        }

        public void Save(List<DeviceItem> item)
        {
            data = item;
        }
    }
}
