namespace InterfaceSegregation.Combo;

public class ComboService : IComboService
{
    public void OrderBurguer(int quantity)
    {
        Console.WriteLine($"Ordering {quantity} burguers");
    }

    public void OrderFries(int fries)
    {
        Console.WriteLine($"Ordering {fries} fries");

    }
}
