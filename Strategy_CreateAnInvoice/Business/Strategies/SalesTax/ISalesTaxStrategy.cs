using Strategy_CreateAnInvoice.Business.Models;

namespace Strategy_CreateAnInvoice.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
