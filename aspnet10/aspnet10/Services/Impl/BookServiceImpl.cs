using aspnet10.Model;
using aspnet10.Repositories;

namespace aspnet10.Services.Impl
{
    public class BookServiceImpl : IBookService
    {
        private IRepository<Book> _repository;
        public BookServiceImpl(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }
        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
