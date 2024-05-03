using InterfaceSegregation.Burguer;
using InterfaceSegregation.Combo;
using InterfaceSegregation.Fries;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBurguerService order = new BurguerOrderService();

            order.OrderBurguer(2);

            IFriesService order2 = new FriesOrderService();
            order2.OrderFries(2);

            IComboService combo = new ComboService();
            combo.OrderBurguer(2);
        }
    }
}