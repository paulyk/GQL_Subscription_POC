public class Query {

    public string Hello() => "Hello World!";

    public List<Book> GetBooks([Service] BookDbContext context) => context.GetBooks();
}