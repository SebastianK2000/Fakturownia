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
    public class CustomerHistoryViewModel:WszystkieViewModel<Customer>
    {
        #region Constructor
        public CustomerHistoryViewModel()
            : base("Customer")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Customer>(
                invoiceEntities.Customer.ToList()
            );
        }
        #endregion
    }
}

