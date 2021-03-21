using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Models
{
    /// <summary>
    /// This is where the dynamic field names are defined for each given device type
    /// </summary>
    public class DeviceFieldNames
    {
        /// <summary>
        /// Device Field Name Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Reference to Device Type
        /// </summary>
        public Guid DeviceTypeId { get; set; }
        /// <summary>
        /// The name of the field.  Can be used in the UI for table headers or label names
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// The data type of the field, ie string or int
        /// </summary>
        public Type DataType { get; set; }
    }
}
