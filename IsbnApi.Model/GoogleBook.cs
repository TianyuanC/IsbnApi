using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbnApi.Model
{
    /// <summary>
    /// Class GoogleBook.
    /// </summary>
    public class GoogleBook
    {
        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        /// <value>The total items.</value>
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        public IEnumerable<Item> Items { get; set; }
    }
}
