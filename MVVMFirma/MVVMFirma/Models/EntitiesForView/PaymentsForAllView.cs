using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.Entities
{
    public class PaymentsForAllView
    {
        public int PaymentId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentMethodName { get; set; }
        public string Notes { get; set; }
    }
}
