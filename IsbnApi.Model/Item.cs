using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbnApi.Model
{
    /// <summary>
    /// Class Item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the volume information.
        /// </summary>
        /// <value>The volume information.</value>
        public VolumeInfo VolumeInfo { get; set; }
    }
}
