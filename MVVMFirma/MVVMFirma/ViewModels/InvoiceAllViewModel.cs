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
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Number", "Kontrahent NIP", "Kontrahent Nazwa" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Number")
                List = new ObservableCollection<InvoiceForAllView>(List.OrderBy(item => item.Number));
            if (SortField == "Kontrahent NIP")
                List = new ObservableCollection<InvoiceForAllView>(List.OrderBy(item => item.KontrahentNIP));
            if (SortField == "Kontrahent Nazwa")
                List = new ObservableCollection<InvoiceForAllView>(List.OrderBy(item => item.KontrahentNazwa));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Number", "Kontrahent NIP", "Kontrahent Nazwa" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Number")
                List = new ObservableCollection<InvoiceForAllView>(List.Where(item => item.Number != null && item.Number.StartsWith(FindTextBox)));
            if (FindField == "Kontrahent NIP")
                List = new ObservableCollection<InvoiceForAllView>(List.Where(item => item.KontrahentNIP != null && item.KontrahentNIP.StartsWith(FindTextBox)));
            if (FindField == "Kontrahent Nazwa")
                List = new ObservableCollection<InvoiceForAllView>(List.Where(item => item.KontrahentNazwa != null && item.KontrahentNazwa.StartsWith(FindTextBox)));
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

