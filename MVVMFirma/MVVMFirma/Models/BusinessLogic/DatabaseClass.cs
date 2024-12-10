using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class DatabaseClass
    {
        #region Contex - DB
        public InvoiceEntities db { get; set; }
        #endregion
        #region Constructor
        public DatabaseClass(InvoiceEntities db)
        {
            this.db = db;
        }
        #endregion
    }
}
