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
    public class NewInvoiceViewModel:JedenViewModel<Invoice>
    {
        #region Construktor
        public NewInvoiceViewModel()
            : base("New Invoice")
        {
            Item = new Invoice();
            // Messenger oczekujący na kontrahenta z widoku gdzie są allKontrahenci
            Messenger.Default.Register<Kontrahent>(this,getSelectedKontrahent);

            Messenger.Default.Register<Customer>(this, getSelectedCustomer);
        }

        #endregion
        #region Command
        private BaseCommand _CancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new BaseCommand(() => CancelAndClose());
                return _CancelCommand;
            }
        }
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

        private BaseCommand _ShowKontrahent;

        public ICommand ShowKontrahent
        {
            get
            {
                if (_ShowKontrahent == null)
                    _ShowKontrahent = new BaseCommand(() => showKontrahenci());
                return _ShowKontrahent;
            }
        }
        private void showKontrahenci()
        {
            Messenger.Default.Send<string>("KontrahentAll");
        }
        #endregion
        #region Properties
        public bool? IsActive
        {
            get
            {
                return Item.IsActive;
            }
            set
            {
                Item.IsActive = value;
                OnPropertyChanged(() => IsActive);
            }
        }
        public string Number
        {
            get
            {
                return Item.Number;
            }
            set
            {
                Item.Number = value;
                OnPropertyChanged(() => Number);
            }
        }
        public DateTime? Date
        {
            get
            {
                return Item.Date;
            }
            set
            {
                Item.Date = value;
                OnPropertyChanged(() => Date);
            }
        }
        public DateTime? PaymentDeadline
        {
            get
            {
                return Item.PaymentDeadline;
            }
            set
            {
                Item.PaymentDeadline = value;
                OnPropertyChanged(() => PaymentDeadline);
            }
        }
        public bool? IsPaid
        {
            get
            {
                return Item.IsPaid;
            }
            set
            {
                Item.IsPaid = value;
                OnPropertyChanged(() => IsPaid);
            }
        }
        public decimal? HowMuchCost
        {
            get
            {
                return Item.HowMuchCost;
            }
            set
            {
                Item.HowMuchCost = value;
                OnPropertyChanged(() => HowMuchCost);
            }
        }

        public string Notes
        {
            get
            {
                return Item.Notes;
            }
            set
            {
                Item.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }
        public int? IdKontrahenta
        {
            get
            {
                return Item.IdKontrahenta;
            }
            set
            {
                Item.IdKontrahenta = value;
                OnPropertyChanged(() => IdKontrahenta);
            }
        }
        public string KontrahentNazwa { get; set; }
        public string KontrahentNIP { get; set; }
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

        public int? PaymentMethod
        {
            get
            {
                return Item.IdPaymentMethod;
            }
            set
            {
                Item.IdPaymentMethod = value;
                OnPropertyChanged(() => PaymentMethod);
            }
        }


        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> KontrahentItems
        {
            get
            {
                return new KontrahenciB(invoiceEntities).GetKontrahenciKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> PaymentMethodItems
        {
            get
            {
                return new PaymentMethodB(invoiceEntities).GetPaymentMethodKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        private void getSelectedCustomer(Customer cutomer)
        {
            IdCustomer = cutomer.IdCustomer;
            CustomerName = cutomer.Name;
        }
        private void getSelectedKontrahent(Kontrahent kontrahent)
        {
            IdKontrahenta = kontrahent.IdKontrachenta;
            KontrahentNazwa = kontrahent.Name;
            KontrahentNIP = kontrahent.NIP;
        }
        public override void Save()
        {
            invoiceEntities.Invoice.Add(Item);
            invoiceEntities.SaveChanges();
        }

        // Cancel method
        public override void Cancel()
        {
            Item = new Invoice();
        }

        public void CancelAndClose()
        {
            Cancel();

            base.OnRequestClose();
        }
        #endregion

    }
}
