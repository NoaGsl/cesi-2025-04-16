using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp.Exercice01.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public double Amount { get; set; }
    }

    public class InvoiceCalculator
    {
        public double CalculateTotalWithTaxes(Invoice invoice)
        {
            return invoice.Amount * 1.2;
        }
    }

    public class InvoiceSaver
    {
        public void SaveToFile(Invoice invoice)
        {
            // Code pour sauvegarder dans un fichier
        }
    }

    public class InvoicePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            // Code pour imprimer l'Invoice
        }
    }
}
