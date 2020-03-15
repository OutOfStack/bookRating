using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bookRating.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private static readonly IEnumerable<Book> books = new List<Book>
        {
            new Book("To kill a mockingbird", "Harper Lee", new DateTime(1960, 7, 11), "Fiction", 4.27),
            new Book("1984", "George Orwell", new DateTime(1949, 6, 8), "Fiction", 4.18),
            new Book("A Short History of Nearly Everything", "Bill Bryson", new DateTime(2003, 5, 6), "Science", 4.21)
        };

        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books.OrderBy(x => x.Title);
        }
    }
}
