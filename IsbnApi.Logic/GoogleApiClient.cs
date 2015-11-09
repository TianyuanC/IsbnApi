using DALs.Http;
using DALs.Model.Configs;
using DALs.Model.Enums;
using DALs.Model.Interfaces;
using IsbnApi.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IsbnApi.Logic
{
    /// <summary>
    /// Class GoogleApiClient.
    /// </summary>
    public class GoogleApiClient: IGoogleApiClient
    {
        //https://www.googleapis.com/books/v1/volumes?q=isbn:9787544730976

        /// <summary>
        /// The rest client
        /// </summary>
        private readonly IRestClient restClient;

        /// <summary>
        /// The base URL
        /// </summary>
        private const string BaseUrl = "https://www.googleapis.com/books/v1/";

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleApiClient"/> class.
        /// </summary>
        public GoogleApiClient()
        {
            this.restClient = new RestClient();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleApiClient"/> class.
        /// </summary>
        /// <param name="restClient">The rest client.</param>
        public GoogleApiClient(IRestClient restClient)
        {
            this.restClient = restClient;
        }

        /// <summary>
        /// Looks up.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Book.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<Book> LookUpAsync(int key)
        {
            var config = new HttpConfiguration(new Uri(BaseUrl), string.Format("volumes?q=isbn:{0}", key), HttpRequest.Get);
            return await restClient.GetAsync(config, LoadBook);
        }

        /// <summary>
        /// Loads the book.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <returns>Book.</returns>
        private static Book LoadBook(HttpResponseMessage msg)
        {
            return new Book();
        }
    }
}
