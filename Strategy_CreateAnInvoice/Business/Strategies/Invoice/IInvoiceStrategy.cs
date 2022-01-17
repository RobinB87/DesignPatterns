using Strategy_CreateAnInvoice.Business.Models;

namespace Strategy_CreateAnInvoice.Business.Strategies.Invoice
{
    interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}