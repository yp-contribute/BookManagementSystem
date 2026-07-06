using DataAccessLayer.Models;

namespace BookManagementSystem.Repository
{
    public class BookRepository : IBookRepository
    {
        public int Delete(int id)
        {
            // create a new instance of BookContext
            BookContext context = new BookContext();

            // first find the record by id and then delete it
            Book record = context.Books.Find(id);

            // if record is null then return 0
            if (record == null) { return 0;}

            // if record is not null then delete it and return 1
            context.Books.Remove(record);

            // save the changes to the database and return the number of records affected
            int result = context.SaveChanges();
            return result;
        }

        public Book Get(int id)
        {
            // create a new instance of BookContext
            BookContext context = new BookContext();

            // find the record by id and return it
            Book record = context.Books.Find(id);

            return record;
        }

        public List<Book> GetList()
        {
            // create a new instance of BookContext
            BookContext context = new BookContext();

            // get all the records from the database and return it
            var result = context.Books.ToList();

            return result;
        }

        public int Save(Book book)
        {
            // create a new instance of BookContext
            BookContext context = new BookContext();

            // add the record to the database and return the number of records affected
            context.Books.Add(book);

            // save the changes to the database and return the number of records affected
            int result = context.SaveChanges();
            return result;

        }

        public int Update(Book book)
        {
            // create a new instance of BookContext
            BookContext context = new BookContext();

            // update the record in the database and return the number of records affected
            context.Books.Update(book);

            // save the changes to the database and return the number of records affected
            int result = context.SaveChanges();
            return result;
        }
    }
}
