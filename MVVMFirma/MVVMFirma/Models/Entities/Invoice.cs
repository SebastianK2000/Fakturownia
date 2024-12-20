//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMFirma.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.ImportExportLogs = new HashSet<ImportExportLogs>();
            this.Payments = new HashSet<Payments>();
            this.InvoiceItems = new HashSet<InvoiceItems>();
        }
    
        public int IdInvoice { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> IdKontrahenta { get; set; }
        public Nullable<System.DateTime> PaymentDeadline { get; set; }
        public Nullable<int> IdPaymentMethod { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<decimal> HowMuchCost { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> IdCustomer { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportExportLogs> ImportExportLogs { get; set; }
        public virtual Kontrahent Kontrahent { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}
