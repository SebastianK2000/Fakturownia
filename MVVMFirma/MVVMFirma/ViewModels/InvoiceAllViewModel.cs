using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using MVVMFirma.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class InvoiceAllViewModel:WszystkieViewModel<InvoiceForAllView>
    {

        #region Constructor
        public InvoiceAllViewModel()
            : base("Invoices")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<InvoiceForAllView>
            (
                from invoice in invoiceEntities.Invoice // dla każdej faktury z bazy danych faktur
                select new InvoiceForAllView // tworzymy nową InvoiceForAllView i uzupełniamy dane
                {
                    IdInvoice = invoice.IdInvoice,
                    Status = invoice.Status,
                    Number = invoice.Number,
                    Date = invoice.Date,
                    KontrahentNIP = invoice.Kontrahent.NIP,
                    KontrahentNazwa = invoice.Kontrahent.Name,
                    PaymentDeadline = invoice.PaymentDeadline,
                    PaymentMethodName = invoice.PaymentMethod.Name,
                    IsPaid = invoice.IsPaid,
                    IsActive = invoice.IsActive,
                    HowMuchCost = invoice.HowMuchCost,
                    Notes = invoice.Notes,
                }
            );
        }
        #endregion
    }
}

