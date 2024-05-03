namespace LiskovSubstitution;

public class Square : IBaseShape
{
    public int Width { get; private set; }

    public void SetWidth(int width)
    {
        Width = width;
    }

    public void CalculateArea()
    {
        Console.WriteLine($"SQUARE AREA: {Width * 4}");
    }
}
