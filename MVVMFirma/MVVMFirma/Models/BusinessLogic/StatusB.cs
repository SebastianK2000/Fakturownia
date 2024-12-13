using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class StatusB : DatabaseClass
    {
        #region Constructor
        public StatusB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetStatusKeyAndValueItems()
        {
            return
                (
                    from status in db.Status
                    select new KeyAndValue
                    {
                        Key = status.IdStatus,
                        Value = status.Name
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
