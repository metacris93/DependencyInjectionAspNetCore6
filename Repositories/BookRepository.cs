using DependencyInjectionAspNetCore.Models;

namespace DependencyInjectionAspNetCore.Repositories
{
  public class BookRepository : IBookRepository
  {
    private List<Book> books = new List<Book>();
    public int AddBook(Book book)
    {
      book.Id = books.Count + 1;
      books.Add(book);
      return book.Id;
    }
    public List<Book> GetAllBooks()
    {
      return books;
    }
  }
}