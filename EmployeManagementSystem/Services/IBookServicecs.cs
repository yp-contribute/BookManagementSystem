using DataAccessLayer.Models;

namespace BookManagementSystem.Services
{
    public interface IBookServicecs
    {   
        // Read
        List<Book> GetAllBooks();

        Book GetBook(int id);

        // Create
        int SaveBook(Book book);

        // Update
        int updateBook(Book book);

        // Delete
        int deleteBook(int id);
    }
}
