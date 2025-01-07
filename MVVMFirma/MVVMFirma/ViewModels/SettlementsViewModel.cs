using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System.Collections.Generic;
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
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Id Payments", "Name" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Id Payments")
                List = new ObservableCollection<PaymentMethod>(List.OrderBy(item => item.IdPayments));
            if (SortField == "Name")
                List = new ObservableCollection<PaymentMethod>(List.OrderBy(item => item.Name));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Id Payments", "Name" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Id Payments")
            {
                if (int.TryParse(FindTextBox, out int IdPayments))
                {
                    List = new ObservableCollection<PaymentMethod>(
                        List.Where(item => item.IdPayments == IdPayments)
                    );
                }
            }
            if (FindField == "Name")
                List = new ObservableCollection<PaymentMethod>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
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
