namespace Lab2._1.Entities;

/// <summary>
/// Represents an author entity in the database.
/// </summary>
public class Author
{
    /// <summary>
    /// Gets or sets the unique identifier for the author.
    /// </summary>
    public int AuthorId { get; set; }

    /// <summary>
    /// Gets or sets the name of the author.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address of the author.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date when the author was created in the system.
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the collection of books written by this author.
    /// </summary>
    public ICollection<Book> Books { get; set; } = new List<Book>();
}
