using Strategy_CreateAnInvoice.Business.Models;
using Strategy_CreateAnInvoice.Business.Strategies.Invoice;
using Strategy_CreateAnInvoice.Business.Strategies.SalesTax;
using System;

namespace Strategy_CreateAnInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails 
                { 
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                },
                SalesTaxStrategy = new SwedenSalesTaxStrategy()
            };
            
            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

            order.SelectedPayments.Add(new Payment
            {
                PaymentProvider = PaymentProvider.Invoice
            });

            Console.WriteLine(order.GetTax());

            // Send the invoice to the user based on the strategy they want
            order.InvoiceStrategy = new FileInvoiceStrategy();
            order.FinalizeOrder();
        }
    }
}
