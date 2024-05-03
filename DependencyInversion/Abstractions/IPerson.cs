namespace DependencyInversion.Abstraction;

public interface IPerson
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
}
