using MVVMFirma.Models.Entities;
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
