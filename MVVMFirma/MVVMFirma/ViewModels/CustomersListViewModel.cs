using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class CustomersListViewModel : WszystkieViewModel<Customer>
    {
        #region Constructor
        public CustomersListViewModel()
            : base("Customers")
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

