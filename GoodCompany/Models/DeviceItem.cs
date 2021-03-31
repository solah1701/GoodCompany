using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Models
{
    /// <summary>
    /// This data structure will store the properties dynamically as defined in the
    /// DeviceFieldName data model
    /// </summary>
    public class DeviceItem
    {
        /// <summary>
        /// Device Item Id
        /// Note, this particular Id will be duplicated and will be used
        /// next to the DeviceFieldNameId as a combined key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Reference to Device Field Name
        /// </summary>
        public int DeviceFieldNameId { get; set; }
        /// <summary>
        /// Reference to Device Type
        /// </summary>
        public int DeviceTypeId { get; set; }
        /// <summary>
        /// The value for the given field of the item
        /// </summary>
        public object Value { get; set; }
    }
}
