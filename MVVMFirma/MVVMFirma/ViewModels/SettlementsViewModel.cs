using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class SettlementsViewModel : WszystkieViewModel<Payments>
    {
        #region Constructor
        public SettlementsViewModel()
            : base("Payments")
        {
            Load();
        }
        #endregion

        #region Properties
        public ObservableCollection<Payments> PaymentsList { get; set; }
        public ObservableCollection<PaymentMethod> PaymentMethodsList { get; set; }
        #endregion

        #region Helpers
        public override void Load()
        {
            PaymentsList = new ObservableCollection<Payments>(
                invoiceEntities.Payments.ToList()
            );

            PaymentMethodsList = new ObservableCollection<PaymentMethod>(
                invoiceEntities.PaymentMethod.ToList()
            );
        }
        #endregion
    }
}
