namespace LiskovSubstitution;

public class Triangle : Shape
{
    public override void CalculateArea()
    {
        Console.WriteLine($"Triangle area: { Width * Height}");
    }
}
