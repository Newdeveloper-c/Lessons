namespace WebApplication1.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public List<Genre>? Genres { get; set; }

    public float Price { get; set; }
    public int WriterId { get; set; }
}

public enum Genre
{
    Fiction,
    Fantasy,
    Mystery,
    Romance,
    ScienceFiction,
    Horror,
    Thriller,
    Biography,
    NonFiction,
    YoungAdult,
    Classics,
    ComicsGraphicNovels,
    History,
    SelfHelp
}