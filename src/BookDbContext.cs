

public class BookDbContext {

    private List<Book> Books = new List<Book>() {
        new Book() { Id = 1, Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien" },
        new Book() { Id = 2, Title = "The Two Towers", Author = "J.R.R. Tolkien" },
        new Book() { Id = 3, Title = "Fooled By RAndomness", Author = "Nassim Nicholas Taleb" },
        new Book() { Id = 4, Title = "The Beginning of Infinity", Author = "David Deutsch" },
    };

    public List<Book> GetBooks() => Books;
}