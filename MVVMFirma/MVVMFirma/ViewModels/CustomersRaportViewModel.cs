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
    public class CustomersRaportViewModel:WszystkieViewModel<CustomerRaport>
    {
        #region Construktor

        public CustomersRaportViewModel()
            : base("Raport Cutomer")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<CustomerRaport>
                (
                    invoiceEntities.CustomerRaport.ToList()
                );
        }
        #endregion
    }
}