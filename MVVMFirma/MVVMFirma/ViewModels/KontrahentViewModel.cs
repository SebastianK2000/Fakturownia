using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class KontrahentViewModel:WszystkieViewModel<KontrahentForAllView>
    {
        #region Constructor
        public KontrahentViewModel()
            : base("Kontrahent")
        {
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Code", "NIP", "Name" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Code")
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.Code));
            if (SortField == "NIP")
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.NIP));
            if (SortField == "Name")
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.Name));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Code", "NIP", "Name" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Code")
                List = new ObservableCollection<KontrahentForAllView>(List.Where(item => item.Code != null && item.Code.StartsWith(FindTextBox)));
            if (FindField == "NIP")
                List = new ObservableCollection<KontrahentForAllView>(List.Where(item => item.NIP != null && item.NIP.StartsWith(FindTextBox)));
            if (FindField == "Name")
                List = new ObservableCollection<KontrahentForAllView>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KontrahentForAllView>
            (
                from kontrahent in invoiceEntities.Kontrahent
                select new KontrahentForAllView
                {
                    IdKontrahent = kontrahent.IdKontrachenta,
                    Code = kontrahent.Code,
                    NIP = kontrahent.NIP,
                    Name = kontrahent.Name,
                    KindName = kontrahent.Kind.Name,
                    StatusName = kontrahent.Status.Name,
                    AdressStreet = kontrahent.Adress.Street,
                    AdressCity = kontrahent.Adress.City,
                    AdressNrHome = kontrahent.Adress.NrHome,
                    AdressNrLocal = kontrahent.Adress.NrLocal,
                    AdressZipCode = kontrahent.Adress.ZipCode,
                }
            );
        }
        #endregion
    }
}
