using Newtonsoft.Json;
using Strategy_CreateAnInvoice.Business.Models;
using System;
using System.Net.Http;

namespace Strategy_CreateAnInvoice.Business.Strategies.Invoice
{
    // Here, not leverage the abstract class, but the interface  itself,
    // because we are not going to get a text representation to pass to this print on demand service
    //
    // The used API is purely fictional
    public class PrintOnDemandInvoiceStrategy : IInvoiceStrategy
    {
        public void Generate(Order order)
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(order);

                client.BaseAddress = new Uri("https://pluralsight.com");

                client.PostAsync("/print-on-demand", new StringContent(content));
            }
        }
    }
}