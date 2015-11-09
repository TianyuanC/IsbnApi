using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsbnApi.Model;

namespace IsbnApi.Logic
{
    /// <summary>
    /// Class Books.
    /// </summary>
    public class Books : IBooks
    {
        /// <summary>
        /// The google client
        /// </summary>
        private readonly IGoogleApiClient googleClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Books"/> class.
        /// </summary>
        public Books():this(new GoogleApiClient())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Books"/> class.
        /// </summary>
        /// <param name="googleClient">The google client.</param>
        public Books(IGoogleApiClient googleClient)
        {
            this.googleClient = googleClient;
        }

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Book.</returns>
        public async Task<Book> GetAsync(string key)
        {
            return await googleClient.LookUpAsync(key);
        }
    }
}
