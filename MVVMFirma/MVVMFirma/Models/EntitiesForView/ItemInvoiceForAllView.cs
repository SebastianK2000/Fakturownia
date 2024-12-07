using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class ItemInvoiceForAllView
    {
        // Invoice 
        public int IdInvoiceItem { get; set; }
        public bool? InvoiceStatus { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoicePaymentDeadline { get; set; }
        public bool? InvoiceIsPaid { get; set; }
        public bool? InvoiceIsActive { get; set; }
        public decimal? InvoiceHowMuchCost { get; set; }
        public string InvoiceNotes { get; set; }

        // Towar
        public string TowarName { get; set; }
        public string TowarCode { get; set; }
        public decimal? TowarPurchasePate { get; set; }
        public decimal? TowarSalesRate { get; set; }
        public decimal? TowarPrice { get; set; }
        public decimal? TowarSpread { get; set; }
        public string TowarNotes { get; set; }

        // Primary
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
