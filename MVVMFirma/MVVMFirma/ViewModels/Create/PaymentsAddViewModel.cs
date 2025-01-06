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
    public class PaymentsAddViewModel : JedenViewModel<Payments>
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
        #endregion
        #region Helpers
        private void getSelectedInvoice(Invoice invoice)
        {
            IdInvoice = invoice.IdInvoice;
            InvoiceNumber = invoice.Number;
        }
        public override void Save()
        {
            invoiceEntities.Payments.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
