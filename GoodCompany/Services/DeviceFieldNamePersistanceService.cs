using GoodCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public class DeviceFieldNamePersistanceService : IPersistence<DeviceFieldNames>
    {
        private readonly List<DeviceFieldNames> data;

        public DeviceFieldNamePersistanceService()
        {
            data = new List<DeviceFieldNames>
            {
                new DeviceFieldNames { Id = 1, DeviceType = "Desktop PC", FieldName = "Id" },
                new DeviceFieldNames { Id = 2, DeviceType = "Desktop PC", FieldName = "Computer Type" },
                new DeviceFieldNames { Id = 3, DeviceType = "Desktop PC", FieldName = "Processor" },
                new DeviceFieldNames { Id = 4, DeviceType = "Desktop PC", FieldName = "Brand" },
                new DeviceFieldNames { Id = 5, DeviceType = "Desktop PC", FieldName = "USB Ports" },
                new DeviceFieldNames { Id = 6, DeviceType = "Desktop PC", FieldName = "RAM Slots" },
                new DeviceFieldNames { Id = 7, DeviceType = "Desktop PC", FieldName = "Form Factor" },
                new DeviceFieldNames { Id = 8, DeviceType = "Desktop PC", FieldName = "Quantity" },
                new DeviceFieldNames { Id = 9, DeviceType = "Laptop", FieldName = "Screen Size" }
            };
        }
        public void Add(DeviceFieldNames item)
        {
            throw new NotImplementedException();
        }

        public List<DeviceFieldNames> Load()
        {
            return data;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
