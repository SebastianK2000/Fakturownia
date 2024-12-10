using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class SettlementsViewModel : WszystkieViewModel<PaymentMethod>
    {
        #region Constructor
        public SettlementsViewModel()
            : base("Payments Method")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<PaymentMethod>
            (
                invoiceEntities.PaymentMethod.ToList()
            );
        }
        #endregion
    }
}
