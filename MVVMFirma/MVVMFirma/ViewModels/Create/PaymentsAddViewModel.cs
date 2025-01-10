using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using MVVMFirma.Validators;
using MVVMFirma.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace MVVMFirma.ViewModels
{
    public class PaymentsAddViewModel : JedenViewModel<Payments>, IDataErrorInfo
    {
        #region Construktor
        public PaymentsAddViewModel()
            : base("Payments")
        {
            Item = new Payments();

            // Messenger oczekujący na kontrahenta z widoku gdzie są allKontrahenci
            Messenger.Default.Register<Invoice>(this, getSelectedInvoice);
        }

        #endregion
        #region Command
        private BaseCommand _ShowInvoice;

        public ICommand ShowInvoice
        {
            get
            {
                if (_ShowInvoice == null)
                    _ShowInvoice = new BaseCommand(() => showInvoice());
                return _ShowInvoice;
            }
        }
        private void showInvoice()
        {
            Messenger.Default.Send<string>("InvoiceAll");
        }
        #endregion
        #region Properties
        public decimal? Amount
        {
            get
            {
                return Item.Amount;
            }
            set
            {
                Item.Amount = value;
                OnPropertyChanged(() => Amount);
            }
        }

        public int? IdPyments
        {
            get { return Item.IdPyments; }
            set
            {
                Item.IdPyments = value;
                OnPropertyChanged(() => IdPyments);
            }
        }
        public string IdPaymentsName { get; set; }

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

        public DateTime? PaymentDate
        {
            get
            {
                return Item.PaymentDate;
            }
            set
            {
                Item.PaymentDate = value;
                OnPropertyChanged(() => PaymentDate);
            }
        }
        public int? IdInvoice
        {
            get
            {
                return Item.IdInvoice;
            }
            set
            {
                Item.IdInvoice = value;
                OnPropertyChanged(() => IdInvoice);
            }
        }
        public string InvoiceNumber { get; set; }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> InvoiceItems
        {
            get
            {
                return new InvoiceB(invoiceEntities).GetInvoiceKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> IdPaymentsItems
        {
            get
            {
                return new PaymentMethodB(invoiceEntities).GetPaymentMethodKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        private void getSelectedInvoice(Invoice invoice)
        {
            IdInvoice = invoice.IdInvoice;
            InvoiceNumber = invoice.Number;
        }
        private void getSelectedPaymentMethod(PaymentMethod paymentMethod)
        {
            IdPaymentsName = paymentMethod.Name;
        }
        public override void Save()
        {
            invoiceEntities.Payments.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
        #region Validation
        public string Error => string.Empty;
        private string _validateMessage = string.Empty;
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == nameof(Amount))
                {
                    _validateMessage = BusinessValidator.ValidateIsPositive(Amount);
                }
                return _validateMessage;
            }
        }

        public override bool IsValid()
        {
            return string.IsNullOrEmpty(_validateMessage);
        }
        #endregion
    }
}
