using BookManagementSystem.Repository;
using DataAccessLayer.Models;

namespace BookManagementSystem.Services
{
    public class BookService : IBookServicecs
    {
        public int deleteBook(int id)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Delete(id);
        }

        public List<Book> GetAllBooks()
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.GetList();
        }

        public Book GetBook(int id)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Get(id);
        }

        public int SaveBook(Book book)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Save(book);
        }

        public int updateBook(Book book)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Update(book);
        }
    }
}
