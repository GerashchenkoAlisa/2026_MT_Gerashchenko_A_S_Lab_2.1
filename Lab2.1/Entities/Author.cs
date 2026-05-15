namespace Lab2._1.Entities;

public class Author
{
    public int AuthorId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}
