namespace LiskovSubstitution;

public class Rectangle : Shape
{
    public override void CalculateArea()
    {
        Console.WriteLine($"RECTANGLE AREA: {(Width * 2) + (Height * 2)}");
    }
}
