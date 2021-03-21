using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Models
{
    /// <summary>
    /// This is where the different device types will be defined
    /// </summary>
    public class DeviceType
    {
        /// <summary>
        /// Device Type Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The name of the Device Type
        /// </summary>
        public string Name { get; set; }
    }
}
