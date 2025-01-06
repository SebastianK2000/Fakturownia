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
    public class NotificationsAddViewModel : JedenViewModel<Notifications>
    {
        #region Construktor
        public NotificationsAddViewModel()
            : base("Notifications")
        {
            Item = new Notifications();
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
        public string Message
        {
            get
            {
                return Item.Message;
            }
            set
            {
                Item.Message = value;
                OnPropertyChanged(() => Message);
            }
        }
        public DateTime? SendDate
        {
            get
            {
                return Item.SendDate;
            }
            set
            {
                Item.SendDate = value;
                OnPropertyChanged(() => SendDate);
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
            invoiceEntities.Notifications.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
