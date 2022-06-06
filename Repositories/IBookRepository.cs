using DependencyInjectionAspNetCore.Models;

namespace DependencyInjectionAspNetCore.Repositories
{
  public interface IBookRepository
  {
    int AddBook(Book book);
    List<Book> GetAllBooks();
  }
}