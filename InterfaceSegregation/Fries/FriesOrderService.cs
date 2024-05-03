namespace InterfaceSegregation.Fries;

public class FriesOrderService : IFriesService
{
    public void OrderFries(int fries)
    {
        Console.WriteLine($"Ordering {fries} fries");
    }
}
