namespace Lab2._1.Entities;

public class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int PageCount { get; set; }

    public int AuthorId { get; set; }

    public DateTime PublishedDate { get; set; }

    public Author? Author { get; set; }

    public ICollection<Issue> Issues { get; set; } = new List<Issue>();
}
