using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Endpoints;

[ApiController]
[Route("api/[controller]")]
public class BooksController : Controller
{
    private static int booksCount = 0;
    private List<Book> Books = new();

    [HttpPost]
    public IActionResult CreateBook(CreateBookDTO book)
    {
        var newBook = new Book()
        {
            Id = booksCount++,
            Name = book.Name,
            AuthorName = book.AuthorName,
            Genres = book.Genres,
            Price = book.Price,
            WriterId = book.WriterId,
        };

        Books.Add(newBook);

        return Ok(newBook);
    }

}
