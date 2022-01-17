using Strategy.Business.Models;

namespace Strategy.Business.Strategies.SalesTax
{
    public class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        // When this strategy is applied we can trust that whoever is injecting this implementation
        // in to the order, has made sure it is the appropriate strategy
        //
        // Making changes does not affect other countries
        public decimal GetTaxFor(Order order)
        {
            var totalTax = 0m;

            foreach (var item in order.LineItems)
            {
                switch(item.Key.ItemType)
                {
                    case ItemType.Food:
                        totalTax += (item.Key.Price * 0.06m) * item.Value;
                        break;

                    case ItemType.Literature:
                        totalTax += (item.Key.Price * 0.08m) * item.Value;
                        break;

                    case ItemType.Service:
                    case ItemType.Hardware:
                        totalTax += (item.Key.Price * 0.25m) * item.Value;
                        break;
                }
            }

            return totalTax;
        }
    }
}