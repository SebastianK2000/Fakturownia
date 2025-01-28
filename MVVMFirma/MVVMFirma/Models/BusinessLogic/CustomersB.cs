using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Linq;

namespace MVVMFirma.Models.BusinessLogic
{
    public class CustomersB : DatabaseClass
    {
        #region Constructor
        public CustomersB(InvoiceEntities db)
            : base(db) { }
        #endregion

        #region Business function
        // Pobiera klientów w formacie klucz-wartość
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

        public int GetNewCustomersCount(DateTime dataOd, DateTime dataDo)
        {
            return db.Customer
                .Where(customer => customer.CreatedAt >= dataOd && dataDo <= dataDo)
                .Count();
        }
        #endregion
    }
}
