namespace InterfaceSegregation;

public interface IOrderService
{
    public void OrderBurguer(int quantity);
    public void OrderFries(int fries);
    public void OrderCombo(int quantity, int fries);
}
