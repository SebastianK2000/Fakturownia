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
