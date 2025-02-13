public class Library
{
    private List<Book> _books;

    public Library()
    {
        _books = new List<Book>();
    }

    public void Dispaly()
    {
        foreach(Book b in _books)
        {
            b.Display();
        }
    }

    public void AddBook(Book theBook)
    {
        _books.Add(theBook);
    }
}