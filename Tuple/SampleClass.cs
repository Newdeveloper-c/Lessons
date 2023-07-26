namespace Tuple;

public record SampleClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }

    public static SampleClass GetSample()
    => new SampleClass { Id = 1, Name = "Name", Description = "Description", Type = "Notype" };
}
