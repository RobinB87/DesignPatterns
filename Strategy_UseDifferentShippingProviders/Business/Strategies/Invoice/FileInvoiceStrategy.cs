﻿using System;
using System.IO;
using Strategy_UseDifferentShippingProviders.Business.Models;

namespace Strategy_UseDifferentShippingProviders.Business.Strategies.Invoice
{
    public class FileInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (var stream = new StreamWriter($"invoice_{Guid.NewGuid()}.txt"))
            {
                stream.Write(GenerateTextInvoice(order));

                stream.Flush();
            }
        }
    }
}
