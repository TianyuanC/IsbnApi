using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsbnApi.Model;

namespace IsbnApi.Logic.Conversion
{
    /// <summary>
    /// Class GoogleBookConversion.
    /// </summary>
    public static class GoogleBookConversion
    {
        /// <summary>
        /// To the book.
        /// </summary>
        /// <param name="googleBook">The google book.</param>
        /// <returns>Book.</returns>
        public static Book ToBook(this GoogleBook googleBook)
        {
            if (googleBook == null || googleBook.TotalItems == 0)
            {
                return new Book();
            }
            Item item = googleBook.Items.FirstOrDefault();
            if (item == null)
            {
                return new Book();
            }
        
            Book book = new Book{
                Authors = item.VolumeInfo.Authors, 
                Title = item.VolumeInfo.Title, 
                Id = item.Id};
            return book;
        }
    }
}
