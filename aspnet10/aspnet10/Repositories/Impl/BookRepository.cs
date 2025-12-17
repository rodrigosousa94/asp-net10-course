using aspnet10.Model.Context;
using aspnet10.Model;


namespace aspnet10.Repositories.Impl
{
    public class BookRepository : IBookRepository
    {
        private MSSQLContext _context;
        public BookRepository(MSSQLContext context)
        {
            _context = context;
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(long id)
        {
            return _context.Books.Find(id);
        }

        public Book Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book Update(Book book)
        {
            var bookToUpdated = _context.Books.Find(book.Id);

            if (bookToUpdated == null) return null;

            _context.Entry(bookToUpdated).CurrentValues.SetValues(book);
            _context.SaveChanges();
            return bookToUpdated;
        }

        public void Delete(long id)
        {
            var bookToUpdated = _context.Books.Find(id);

            if (bookToUpdated == null) return;

            _context.Books.Remove(bookToUpdated);
            _context.SaveChanges();
        }
    }
}
