using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbnApi.Model
{
    /// <summary>
    /// Interface IGoogleApiClient
    /// </summary>
    public interface IGoogleApiClient
    {
        /// <summary>
        /// Looks up.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Book.</returns>
        Book LookUp(int key);
    }
}
