using DependencyInversion.Abstraction;

namespace DependencyInversion;

public class Person :IPerson
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
}
