using MVVMFirma.Models.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class PaymentViewModel : WszystkieViewModel<PaymentsForAllView>
    {
        #region Constructor
        public PaymentViewModel()
            : base("Payments")
        {
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Payment Id", "Invoice number", "Amount" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Payment Id")
                List = new ObservableCollection<PaymentsForAllView>(List.OrderBy(item => item.PaymentId));
            if (SortField == "Invoice number")
                List = new ObservableCollection<PaymentsForAllView>(List.OrderBy(item => item.InvoiceNumber));
            if (SortField == "Amount")
                List = new ObservableCollection<PaymentsForAllView>(List.OrderBy(item => item.Amount));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Payment Id", "Invoice number", "Amount" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Payment Id")
            {
                if (int.TryParse(FindTextBox, out int PaymentId))
                {
                    List = new ObservableCollection<PaymentsForAllView>(
                        List.Where(item => item.PaymentId == PaymentId)
                    );
                }
            }

            if (FindField == "Invoice number")
                List = new ObservableCollection<PaymentsForAllView>(
                    List.Where(item => item.InvoiceNumber != null && item.InvoiceNumber.StartsWith(FindTextBox))
                );

            if (FindField == "Amount")
            {
                if (decimal.TryParse(FindTextBox, out decimal amount))
                {
                    List = new ObservableCollection<PaymentsForAllView>(
                        List.Where(item => item.Amount != null && item.Amount == amount)
                    );
                }
            }
        }
        #endregion
            #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<PaymentsForAllView>
            (
                from payments in invoiceEntities.Payments
                select new PaymentsForAllView
                {
                    PaymentId = payments.PaymentId,
                    InvoiceNumber = payments.Invoice.Number,
                    PaymentDate = payments.PaymentDate,
                    Amount = payments.Amount,
                    PaymentMethodName = payments.PaymentMethod.Name,
                    Notes = payments.Notes,
                }
            );
        }
        #endregion
    }
}
