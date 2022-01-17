using Strategy_UseDifferentShippingProviders.Business.Models;

namespace Strategy_UseDifferentShippingProviders.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
