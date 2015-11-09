using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbnApi.Model
{
    /// <summary>
    /// Interface IBooks
    /// </summary>
    public interface IBooks
    {
        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Book.</returns>
        Task<Book> GetAsync(string key);
    }
}
