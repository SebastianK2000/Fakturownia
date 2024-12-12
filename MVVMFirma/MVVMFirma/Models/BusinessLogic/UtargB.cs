using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class UtargB:DatabaseClass
    {
        #region Constructor
        public UtargB(InvoiceEntities db)
            :base(db) { }
        #endregion
        #region Business function
        // funkcja do obliczania utargu danego towaru - okres od:do
        public decimal? UtargOkresTowar(int idTowar, DateTime dataOd, DateTime dataDo)
        {
            return
                (
                    from pozycja in db.InvoiceItems
                    where
                    pozycja.IdTowar == idTowar && 
                    pozycja.Invoice.Date>= dataOd && 
                    pozycja.Invoice.Date<= dataDo
                    select pozycja.Price*pozycja.Quantity
                ).Sum();
        }
        #endregion
    }
}
