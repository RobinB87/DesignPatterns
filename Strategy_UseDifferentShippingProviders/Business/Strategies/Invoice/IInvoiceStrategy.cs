using Strategy_UseDifferentShippingProviders.Business.Models;

namespace Strategy_UseDifferentShippingProviders.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}