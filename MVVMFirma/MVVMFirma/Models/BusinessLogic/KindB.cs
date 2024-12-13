using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class KindB : DatabaseClass
    {
        #region Constructor
        public KindB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetKindKeyAndValueItems()
        {
            return
                (
                    from kind in db.Kind
                    select new KeyAndValue
                    {
                        Key = kind.IdKind,
                        Value = kind.Name
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
