using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class CustomersB:DatabaseClass
    {
        #region Constructor
        public CustomersB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetCustomersKeyAndValueItems()
        {
            return
                (
                    from customers in db.Customer
                    select new KeyAndValue
                    {
                        Key = customers.IdCustomer,
                        Value = customers.Name + " " + customers.Email
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
