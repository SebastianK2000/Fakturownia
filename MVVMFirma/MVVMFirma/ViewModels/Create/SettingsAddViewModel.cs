using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class SettingsAddViewModel : JedenViewModel<Settings>
    {
        #region Constructor
        public SettingsAddViewModel()
            : base("Settings")
        {
            Item = new Settings();
            Languages = new ObservableCollection<string> { "Polish", "English", "Spanish", "French", "German",  "Chinese", "Hindi", "Arabic", "Bengali", "Russian", "Portuguese" };

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
        private ObservableCollection<string> _languages;
        public ObservableCollection<string> Languages
        {
            get { return _languages; }
            set
            {
                _languages = value;
                OnPropertyChanged(() => Languages);
            }
        }

        public string Language
        {
            get { return Item.Language; }
            set
            {
                Item.Language = value;
                OnPropertyChanged(() => Language);
            }
        }

        public string Login
        {
            get { return Item.Login; }
            set
            {
                Item.Login = value;
                OnPropertyChanged(() => Login);
            }
        }

        public string Password
        {
            get { return Item.Password; }
            set
            {
                Item.Password = value;
                OnPropertyChanged(() => Password);
            }
        }

        public bool? PaymentDeadlineTrigger
        {
            get { return Item.PaymentDeadlineTrigger; }
            set
            {
                Item.PaymentDeadlineTrigger = value;
                OnPropertyChanged(() => PaymentDeadlineTrigger);
            }
        }

        public bool? NewInvoiceTrigger
        {
            get { return Item.NewInoviceTrigger; }
            set
            {
                Item.NewInoviceTrigger = value;
                OnPropertyChanged(() => NewInvoiceTrigger);
            }
        }

        public bool? PaymentNotMade
        {
            get { return Item.PymentNotMade; }
            set
            {
                Item.PymentNotMade = value;
                OnPropertyChanged(() => PaymentNotMade);
            }
        }

        public int? IdCustomer
        {
            get { return Item.IdCustomer; }
            set
            {
                Item.IdCustomer = value;
                OnPropertyChanged(() => IdCustomer);
            }
        }

        public string CustomerName { get; set; }
        #endregion

        #region Properties for ComboBox 
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        #endregion

        #region Helpers
        private void getSelectedCustomer(Customer customer)
        {
            IdCustomer = customer.IdCustomer;
            CustomerName = customer.Name;
        }

        public override void Save()
        {
            invoiceEntities.Settings.Add(Item);
            invoiceEntities.SaveChanges();
        }

        // Cancel method
        public override void Cancel()
        {
            Item = new Settings();
            // Zamyka okno po anulowaniu
            base.OnRequestClose();
        }

        #endregion
    }
}
