using Strategy_CreateAnInvoice.Business.Models;

namespace Strategy_CreateAnInvoice.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}