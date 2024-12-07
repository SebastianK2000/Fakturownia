using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class SettlementsViewModel : WszystkieViewModel<PaymentsForAllView>
    {
        #region Constructor
        public SettlementsViewModel()
            : base("Payments")
        {
        }
        #endregion

        #region Properties
        public ObservableCollection<PaymentsForAllView> PaymentsList { get; set; }
        public ObservableCollection<PaymentMethod> PaymentMethodsList { get; set; }
        #endregion

        #region Helpers
        public override void Load()
        {
            PaymentsList = new ObservableCollection<PaymentsForAllView>
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

            PaymentMethodsList = new ObservableCollection<PaymentMethod>(
                invoiceEntities.PaymentMethod.ToList()
            );
        }
        #endregion
    }
}
