using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class CustomersRaportViewModel:WorkspaceViewModel
    {
        #region DB
        InvoiceEntities db;
        #endregion
        #region Construktor
        public CustomersRaportViewModel()
        {
            base.DisplayName = "Customers Raport";
            db = new InvoiceEntities();
        }
        #endregion
        #region Fields

        #endregion
        #region Command

        #endregion
    }
}