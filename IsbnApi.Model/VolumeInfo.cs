using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbnApi.Model
{
    /// <summary>
    /// Class VolumeInfo.
    /// </summary>
    public class VolumeInfo
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        /// <value>The authors.</value>
        public IEnumerable<string> Authors { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>The published date.</value>
        public string PublishedDate { get; set; }
    }
}
