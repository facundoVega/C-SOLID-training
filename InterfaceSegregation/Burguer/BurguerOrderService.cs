namespace InterfaceSegregation.Burguer;

public class BurguerOrderService : IBurguerService
{
    public void OrderBurguer(int quantity)
    {
        Console.WriteLine($"Ordering  {quantity} burguers.");
    }
}
