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
    public class NewInvoiceViewModel:WorkspaceViewModel
    {
        #region DB
        private InvoiceEntities invoiceEntities;
        #endregion
        #region Item
        private Invoice invoice;
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
        public NewInvoiceViewModel()
        {
            base.DisplayName = "Invoice";
            invoiceEntities = new InvoiceEntities();
            invoice = new Invoice();
        }

        #endregion

        #region Properties
        public bool? Status
        {
            get
            {
                return invoice.Status;
            }
            set
            {
                invoice.Status = value;
                OnPropertyChanged(() => Status);
            }
        }
        public string Number
        {
            get
            {
                return invoice.Number;
            }
            set
            {
                invoice.Number = value;
                OnPropertyChanged(() => Number);
            }
        }
        public DateTime? Date
        {
            get
            {
                return invoice.Date;
            }
            set
            {
                invoice.Date = value;
                OnPropertyChanged(() => Date);
            }
        }
        public DateTime? PaymentDeadline
        {
            get
            {
                return invoice.PaymentDeadline;
            }
            set
            {
                invoice.PaymentDeadline = value;
                OnPropertyChanged(() => PaymentDeadline);
            }
        }
        public bool? IsPaid
        {
            get
            {
                return invoice.IsPaid;
            }
            set
            {
                invoice.IsPaid = value;
                OnPropertyChanged(() => IsPaid);
            }
        }
        public bool? IsActive
        {
            get
            {
                return invoice.IsActive;
            }
            set
            {
                invoice.IsActive = value;
                OnPropertyChanged(() => IsActive);
            }
        }
        public decimal? HowMuchCost
        {
            get
            {
                return invoice.HowMuchCost;
            }
            set
            {
                invoice.HowMuchCost = value;
                OnPropertyChanged(() => HowMuchCost);
            }
        }

        public string Notes
        {
            get
            {
                return invoice.Notes;
            }
            set
            {
                invoice.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }


        #endregion
        #region Helpers
        public void Save()
        {
            invoiceEntities.Invoice.Add(invoice); // dodaje do lokalnej kolekcji
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
