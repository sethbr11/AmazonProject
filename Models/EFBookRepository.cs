namespace AmazonProject.Models;

public class EFBookRepository : IBookRepository
{
    private BookstoreContext _bookRepository;

    public EFBookRepository(BookstoreContext temp)
    {
        _bookRepository = temp;
    }

    public IQueryable<Book> Books => _bookRepository.Books;
}