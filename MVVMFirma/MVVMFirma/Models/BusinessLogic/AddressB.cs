using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class AddressB : DatabaseClass
    {
        #region Constructor
        public AddressB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetAddressKeyAndValueItems()
        {
            return
                (
                    from address in db.Adress
                    select new KeyAndValue
                    {
                        Key = address.IdAdress,
                        Value = address.Street + " " + address.NrHome + " " + address.NrLocal + " " + address.ZipCode + " " + address.City
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
