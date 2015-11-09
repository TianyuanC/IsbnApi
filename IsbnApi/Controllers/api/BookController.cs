using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IsbnApi.Model;
using IsbnApi.Logic;
using System.Threading.Tasks;

namespace IsbnApi.Controllers.api
{
    /// <summary>
    /// Class BookController.
    /// </summary>
    public class BookController : ApiController
    {
        /// <summary>
        /// The books
        /// </summary>
        private readonly IBooks books;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        public BookController() 
        {
            this.books = new Books();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        /// <param name="books">The books.</param>
        public BookController(IBooks books)
        {
            this.books = books;
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>HttpResponseMessage.</returns>
        [HttpGet]
        public async Task<HttpResponseMessage> Get(int id)
        {
            Book book = await books.GetAsync(id);
            return Request.CreateResponse(HttpStatusCode.OK, book);
        }
    }
}
