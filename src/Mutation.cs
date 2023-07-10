
using HotChocolate.Subscriptions;

public class Mutation {

    public async Task<Book> PublishBook(
        int BookId,
        [Service] BookDbContext context,
        [Service] ITopicEventSender eventSender,
        CancellationToken cancellationToken
    ) {
        var book = context.GetBooks().First(b => b.Id == BookId);
        book.Published = DateTimeOffset.UtcNow;
        await eventSender.SendAsync(nameof(PublishBook), book, cancellationToken);
        return book;
    }
}