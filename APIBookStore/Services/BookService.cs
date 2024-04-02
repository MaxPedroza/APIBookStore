using APIBookStore.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using System.Security.AccessControl;

namespace APIBookStore.Services
{
    public class BooksService
    {
        private readonly IMongoCollection <Book> _booksCollection;

        public BooksService(
            IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);
            var mongoDatabase =  mongoClient().GetDatabase(

                )
        }
    }
}
