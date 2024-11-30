using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class CustomerViewModel:WorkspaceViewModel
    {
        #region DB
        private InvoiceEntities invoiceEntities;
        #endregion
        #region Item
        private Customer customer;
        #endregion

        #region Command 
        // komenda która zostanie podpięta pod zapisz/zamknij
        private BaseCommand _SaveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => SaveAndClose());
                return _SaveCommand;
            }
        }
        #endregion

        #region Construktor
        public CustomerViewModel()
        {
            base.DisplayName = "Customer";
            invoiceEntities = new InvoiceEntities();
            customer = new Customer();
        }

        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return customer.Name;
            }
            set
            {
                customer.Name = value;
                OnPropertyChanged(() => Name);
            }
        }
        public string Phone
        {
            get
            {
                return customer.Phone;
            }
            set
            {
                customer.Phone = value;
                OnPropertyChanged(() => Phone);
            }
        }
        public string Email
        {
            get
            {
                return customer.Email;
            }
            set
            {
                customer.Email = value;
                OnPropertyChanged(() => Email);
            }
        }
        public string Notes
        {
            get
            {
                return customer.Notes;
            }
            set
            {
                customer.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }

        #endregion
        #region Helpers
        public void Save()
        {
            invoiceEntities.Customer.Add(customer); // dodaje do lokalnej kolekcji
            invoiceEntities.SaveChanges(); // zapisuje do DB
        }
        public void SaveAndClose()
        {
            Save();
            base.OnRequestClose(); // zamknięcie zakładki
        }
        #endregion

    }
}
