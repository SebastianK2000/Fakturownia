using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class SalesRaportViewModel:WszystkieViewModel<RaportSales>
    {
        #region Construktor

        public SalesRaportViewModel()
            : base("Raport Sales")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<RaportSales>
                (
                    invoiceEntities.RaportSales.ToList()
                );
        }
        #endregion
    }
}