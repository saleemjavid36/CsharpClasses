using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Solid_Principles.OCP
{
    internal class WithoutOCPExample
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            else if (invoiceType == InvoiceType.RecurringInvoice)
            {
                finalAmount = amount - 25;
            }
            return finalAmount;
        }
    }
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice,
        RecurringInvoice
    }
}
