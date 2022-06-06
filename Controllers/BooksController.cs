using DependencyInjectionAspNetCore.Models;
using DependencyInjectionAspNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private readonly IBookRepository _bookRepository;

    private readonly IBookRepository _bookRepository2;

    public BooksController(IBookRepository bookRepository, IBookRepository bookRepository2)
    {
      _bookRepository = bookRepository;
      _bookRepository2 = bookRepository2;
    }
    // [HttpPost("")]
    // public IActionResult AddBook([FromBody] Book book)
    // {
    //   int id = _bookRepository.AddBook(book);
    //   return Ok(id);
    // }
    [HttpPost("")]
    public IActionResult AddBook([FromBody] Book book)
    {
      _bookRepository.AddBook(book);
      var books = _bookRepository2.GetAllBooks();
      return Ok(books);
    }
    [HttpGet("")]
    public IActionResult GetAllBooks()
    {
      var books = _bookRepository.GetAllBooks();
      return Ok(books);
    }
  }
}