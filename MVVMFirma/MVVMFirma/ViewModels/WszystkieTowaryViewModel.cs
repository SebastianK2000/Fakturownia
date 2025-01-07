using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;
using System.Data.Entity.Infrastructure;

namespace MVVMFirma.ViewModels
{
    public class WszystkieTowaryViewModel : WszystkieViewModel<Towar>
    {

        #region Construktor

        public WszystkieTowaryViewModel()
            :base("Towary")
        {
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Code", "Name", "Price" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if(SortField == "Code")
                List = new ObservableCollection<Towar>(List.OrderBy(item => item.Code));
            if (SortField == "Name")
                List = new ObservableCollection<Towar>(List.OrderBy(item => item.Name));
            if (SortField == "Price")
                List = new ObservableCollection<Towar>(List.OrderBy(item => item.Price));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Code", "Name" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if(FindField == "Code")
                List = new ObservableCollection<Towar>(List.Where(item => item.Code != null && item.Code.StartsWith(FindTextBox)));
            if (FindField == "Name")
                List = new ObservableCollection<Towar>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
        }
        #endregion
        #region Helpers
        // metoda load pobierze all towary z DB
        public override void Load()
        {
            List = new ObservableCollection<Towar>
                (
                    invoiceEntities.Towar.ToList() // pobieramy z DB towar i zamieniamy na listę
                );
        }
        #endregion
    }
}