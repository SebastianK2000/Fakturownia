using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class InvoiceB : DatabaseClass
    {
        #region Constructor
        public InvoiceB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetInvoiceKeyAndValueItems()
        {
            return
                (
                    from invoice in db.Invoice
                    select new KeyAndValue
                    {
                        Key = invoice.IdInvoice,
                        Value = invoice.Number + " " + invoice.Date
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
