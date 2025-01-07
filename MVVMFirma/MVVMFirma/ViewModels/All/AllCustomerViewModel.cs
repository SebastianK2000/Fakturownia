using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class AllCustomerViewModel : WszystkieViewModel<Customer>
    {
        #region Construktor

        public AllCustomerViewModel()
            : base("Customers")
        {
        }
        #endregion
        #region Properties
        // do tego propertisa zostanie przypisany Kontrahent kliknięty na liście
        private Customer _SelectedCustomer;
        public Customer SelectedCustomer
        {
            get
            {
                return _SelectedCustomer;
            }
            set
            {
                _SelectedCustomer = value;
                Messenger.Default.Send(_SelectedCustomer);
                OnRequestClose();
            }
        }
        #endregion
        #region Command
        private BaseCommand _ShowCustomers;

        public ICommand ShowCustomers
        {
            get
            {
                if (_ShowCustomers == null)
                    _ShowCustomers = new BaseCommand(() => showCustomers());
                return _ShowCustomers;
            }
        }
        private void showCustomers()
        {
            Messenger.Default.Send<string>("CustomersAll");
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
            List = new ObservableCollection<Customer>
                (
                    invoiceEntities.Customer.ToList()
                );
        }
        #endregion
    }
}
