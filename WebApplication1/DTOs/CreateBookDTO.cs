using WebApplication1.Models;

namespace WebApplication1.DTOs;

public class CreateBookDTO
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public List<Genre>? Genres { get; set; }

    public float Price { get; set; }
    public int WriterId { get; set; }
}
