using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string ComputerType { get; set; }
        public string Processor { get; set; }
        public string Brand { get; set; }
        public int UsbPorts { get; set; }
        public int RamSlots { get; set; }
        public string FormFactor { get; set; }
        public int Quantity { get; set; }
    }
}
