


public class Book {
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    // published
    public DateTimeOffset? Published { get; set; } 
}