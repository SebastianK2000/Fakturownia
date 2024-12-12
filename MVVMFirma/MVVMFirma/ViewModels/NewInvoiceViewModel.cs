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
        //#region DB
        //private InvoiceEntities invoiceEntities;
        //#endregion
        //#region Item
        //private Invoice invoice;
        //#endregion

        //#region Command 
        ////private BaseCommand _SaveCommand;

        ////public ICommand SaveCommand
        ////{
        ////    get
        ////    {
        ////        if (_SaveCommand == null)
        ////            _SaveCommand = new BaseCommand(() => SaveAndClose());
        ////        return _SaveCommand;
        ////    }
        ////}
        ////#endregion

        #region Construktor
        public NewInvoiceViewModel()
            : base("Invoice")
        {
            Item = new Invoice();
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
        public override void Save()
        {
            invoiceEntities.Invoice.Add(Item);
            invoiceEntities.SaveChanges();
        }
        //public void SaveAndClose()
        //{
        //    Save();
        //    base.OnRequestClose();
        //}
        #endregion

    }
}
