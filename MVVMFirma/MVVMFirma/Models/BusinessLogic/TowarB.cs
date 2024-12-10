using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class TowarB : DatabaseClass
    {
        #region Constructor
        public TowarB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetTowaryKeyAndValueItems()
        {
            return 
                (
                    from towar in db.Towar
                    select new KeyAndValue
                    {
                        Key=towar.IdTowaru,
                        Value=towar.Name+" "+towar.Code
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
