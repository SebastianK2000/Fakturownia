using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class AddressAddViewModel : JedenViewModel<Adress>
    {
        #region Construktor
        public AddressAddViewModel()
            : base("Address")
        {
            Item = new Adress();
            // Messenger oczekujący na kontrahenta z widoku gdzie są allKontrahenci
            Messenger.Default.Register<Customer>(this, getSelectedCustomer);
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
        #region Properties
        public string City
        {
            get
            {
                return Item.City;
            }
            set
            {
                Item.City = value;
                OnPropertyChanged(() => City);
            }
        }
        public string Street
        {
            get
            {
                return Item.Street;
            }
            set
            {
                Item.Street = value;
                OnPropertyChanged(() => Street);
            }
        }
        public string NrHome
        {
            get
            {
                return Item.NrHome;
            }
            set
            {
                Item.NrHome = value;
                OnPropertyChanged(() => NrHome);
            }
        }
        public string NrLocal
        {
            get
            {
                return Item.NrLocal;
            }
            set
            {
                Item.NrLocal = value;
                OnPropertyChanged(() => NrLocal);
            }
        }
        public string ZipCode
        {
            get
            {
                return Item.ZipCode;
            }
            set
            {
                Item.ZipCode = value;
                OnPropertyChanged(() => ZipCode);
            }
        }
        public int? IdCustomer
        {
            get
            {
                return Item.IdCustomer;
            }
            set
            {
                Item.IdCustomer = value;
                OnPropertyChanged(() => IdCustomer);
            }
        }
        public string CustomerName { get; set; }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        private void getSelectedCustomer(Customer cutomer)
        {
            IdCustomer = cutomer.IdCustomer;
            CustomerName = cutomer.Name;
        }
        public override void Save()
        {
            invoiceEntities.Adress.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
