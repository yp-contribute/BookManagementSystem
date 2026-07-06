using DataAccessLayer.Models;

namespace BookManagementSystem.Repository
{
    public interface IBookRepository
    {
        List<Book> GetList();

        Book Get(int id);
        int Save(Book book);
        int Update(Book book);
    }
}
