using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Linq;
using MVVMFirma.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MVVMFirma.Models.EntitiesForView;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class PaymentsMethodViewModel : WszystkieViewModel<PaymentMethod>
    {
        #region Constructor
        public PaymentsMethodViewModel()
            : base("Payment Method")
        {
        }
        #endregion

        #region Properties
        public ObservableCollection<PaymentMethod> PaymentMethodsList { get; set; }
        #endregion

        #region Helpers
        public override void Load()
        {
            PaymentMethodsList = new ObservableCollection<PaymentMethod>(
                invoiceEntities.PaymentMethod.ToList()
            );
        }
        #endregion
    }
}
