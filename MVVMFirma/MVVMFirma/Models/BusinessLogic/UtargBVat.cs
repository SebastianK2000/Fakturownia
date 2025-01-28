using MVVMFirma.Models.Entities;
using System;
using System.Linq;

namespace MVVMFirma.Models.BusinessLogic
{
    public class UtargBVat : DatabaseClass
    {
        #region Constructor
        public UtargBVat(InvoiceEntities db)
            : base(db) { }
        #endregion

        #region Business function
        public decimal? UtargOkresTowar(int idTowar, DateTime dataOd, DateTime dataDo)
        {
            return
                (
                    from pozycja in db.InvoiceItems
                    where
                    pozycja.IdTowar == idTowar &&
                    pozycja.Invoice.Date >= dataOd &&
                    pozycja.Invoice.Date <= dataDo
                    select pozycja.Price * pozycja.Quantity
                ).Sum();
        }

        public decimal? ObliczVat(int idTowar, DateTime dataOd, DateTime dataDo, decimal stawkaVat = 0.23m)
        {
            var utarg = UtargOkresTowar(idTowar, dataOd, dataDo);
            if (utarg.HasValue)
            {
                return utarg.Value * stawkaVat;
            }
            return null;
        }
        #endregion
    }
}
