using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    // klasa wzorowana na klasie faktura z wyjątkiem tego że klucze obce mają czytelne dla klienta pola
    public class InvoiceForAllView
    {
        public int IdInvoice { get; set; }
        public string Number {  get; set; }
        public DateTime? Date { get; set; }

        // Nip oraz nazwa zamiast klucza obcego IdKontrahenta
        public string KontrahentNIP { get; set; }
        public string KontrahentNazwa { get; set; }
        public DateTime? PaymentDeadline { get; set; }
        public string PaymentMethodName { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsActive { get; set; }
        public decimal? HowMuchCost { get; set; }
        public string Notes { get; set; }


    }
}
