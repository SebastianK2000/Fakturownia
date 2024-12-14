using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class PaymentsAddViewModel : JedenViewModel<Payments>
    {
        #region Construktor
        public PaymentsAddViewModel()
            : base("Payments")
        {
            Item = new Payments();
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
        public override void Save()
        {
            invoiceEntities.Payments.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
