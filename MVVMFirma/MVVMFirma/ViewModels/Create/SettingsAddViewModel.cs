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
    public class SettingsAddViewModel : JedenViewModel<Settings>
    {
        #region Construktor
        public SettingsAddViewModel()
            : base("Settings")
        {
            Item = new Settings();
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
        public string Language
        {
            get
            {
                return Item.Language;
            }
            set
            {
                Item.Language = value;
                OnPropertyChanged(() => Language);
            }
        }
        public string Login
        {
            get
            {
                return Item.Login;
            }
            set
            {
                Item.Login = value;
                OnPropertyChanged(() => Login);
            }
        }
        public string Password
        {
            get
            {
                return Item.Password;
            }
            set
            {
                Item.Password = value;
                OnPropertyChanged(() => Password);
            }
        }
        public bool? PaymentDeadlineTrigger
        {
            get
            {
                return Item.PaymentDeadlineTrigger;
            }
            set
            {
                Item.PaymentDeadlineTrigger = value;
                OnPropertyChanged(() => PaymentDeadlineTrigger);
            }
        }
        public bool? NewInoviceTrigger
        {
            get
            {
                return Item.NewInoviceTrigger;
            }
            set
            {
                Item.NewInoviceTrigger = value;
                OnPropertyChanged(() => NewInoviceTrigger);
            }
        }
        public bool? PymentNotMade
        {
            get
            {
                return Item.PymentNotMade;
            }
            set
            {
                Item.PymentNotMade = value;
                OnPropertyChanged(() => PymentNotMade);
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
            invoiceEntities.Settings.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
