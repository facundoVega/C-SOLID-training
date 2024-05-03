namespace LiskovSubstitution;

public abstract class Shape : IBaseShape, IHeightShape
{
    public int Width { get; set; }
    public int Height { get; private set; }

    public void SetWidth(int width)
    {
        Width = width;
    }

    public void SetHeight(int height)
    {
        Height = height;
    }

    public abstract void CalculateArea();

}
