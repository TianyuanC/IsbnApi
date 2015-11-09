using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsbnApi.Model;
using System.Globalization;

namespace IsbnApi.Logic
{
    /// <summary>
    /// Class GoogleApiClient.
    /// </summary>
    public class GoogleApiClient: IGoogleApiClient
    {
        /// <summary>
        /// Looks up.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Book.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Book LookUp(int key)
        {
            return new Book { Id = key.ToString(CultureInfo.InvariantCulture), Title = "test" };
        }
    }
}
