using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class PaymentMethodB:DatabaseClass
    {
        #region Constructor
        public PaymentMethodB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetPaymentMethodKeyAndValueItems()
        {
            return
                (
                    from payment in db.PaymentMethod
                    select new KeyAndValue
                    {
                        Key = payment.IdPayments,
                        Value = payment.Name
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
