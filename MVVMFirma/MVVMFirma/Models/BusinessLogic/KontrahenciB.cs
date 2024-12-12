using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class KontrahenciB:DatabaseClass
    {
        #region Constructor
        public KontrahenciB(InvoiceEntities db)
            : base(db) { }
        #endregion
        #region Business function
        public IQueryable<KeyAndValue> GetKontrahenciKeyAndValueItems()
        {
            return
                (
                    from kontrahenci in db.Kontrahent
                    select new KeyAndValue
                    {
                        Key = kontrahenci.IdKontrachenta,
                        Value = kontrahenci.Name + " " + kontrahenci.NIP
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
