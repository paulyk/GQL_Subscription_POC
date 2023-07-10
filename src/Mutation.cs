
public class Mutation {

    public Book PublishBook(
        int BookId,
        [Service] BookDbContext context
    ) {
        var book = context.GetBooks().First(b => b.Id == BookId);
        book.Published = DateTimeOffset.UtcNow;
        return book;
    }
}