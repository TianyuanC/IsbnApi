using System.Collections.Generic;

namespace IsbnApi.Model
{
    /// <summary>
    /// Class Book.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>The author.</value>
        public IEnumerable<string> Authors { get; set; }
    }
}
