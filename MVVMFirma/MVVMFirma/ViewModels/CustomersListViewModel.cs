using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System.Collections.Generic;
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
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "IdCustomer", "Name", "Email" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "IdCustomer")
                List = new ObservableCollection<Customer>(List.OrderBy(item => item.IdCustomer));
            if (SortField == "Name")
                List = new ObservableCollection<Customer>(List.OrderBy(item => item.Name));
            if (SortField == "Email")
                List = new ObservableCollection<Customer>(List.OrderBy(item => item.Email));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "IdCustomer", "Name", "Email" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "IdCustomer")
            {
                if (int.TryParse(FindTextBox, out int IdCustomer))
                {
                    List = new ObservableCollection<Customer>(
                        List.Where(item => item.IdCustomer == IdCustomer)
                    );
                }
            }
            if (FindField == "Name")
                List = new ObservableCollection<Customer>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
            if (FindField == "Email")
                List = new ObservableCollection<Customer>(List.Where(item => item.Email != null && item.Email.StartsWith(FindTextBox)));
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

