using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;
using System.Data.Entity.Infrastructure;
using GalaSoft.MvvmLight.Messaging;

namespace MVVMFirma.ViewModels
{
    public class WszystkieTowaryViewModel : WszystkieViewModel<Towar>
    {
        #region Constructor

        public WszystkieTowaryViewModel()
            : base("Towary")
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
            if (SortField == "Code")
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
            if (FindField == "Code")
                List = new ObservableCollection<Towar>(List.Where(item => item.Code != null && item.Code.StartsWith(FindTextBox)));
            if (FindField == "Name")
                List = new ObservableCollection<Towar>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
        }

        #endregion

        #region Helpers

        // metoda load pobierze wszystkie towary z DB
        public override void Load()
        {
            List = new ObservableCollection<Towar>
                (
                    invoiceEntities.Towar.ToList() // pobieramy z DB towar i zamieniamy na listę
                );
        }

        // Komenda edycji
        public override void Edit()
        {
            // Załóżmy, że masz wybrany element na liście, który chcesz edytować
            var selectedTowar = List.FirstOrDefault(); // Musisz zaimplementować logikę wybierania konkretnego towaru

            if (selectedTowar != null)
            {
                // Wysyłanie komunikatu o edytowaniu, np. zidentyfikowanie wybranego towaru
                Messenger.Default.Send(new NotificationMessage<Towar>(selectedTowar, "Edit"));
            }
        }

        // Komenda usuwania
        public override void Delete()
        {
            var selectedTowar = List.FirstOrDefault(); // Wybierz towar do usunięcia

            if (selectedTowar != null)
            {
                // Potwierdzenie usunięcia (np. komunikat, czy na pewno chcesz usunąć)
                // Wysyłanie komunikatu do głównego widoku
                Messenger.Default.Send(new NotificationMessage<Towar>(selectedTowar, "Delete"));
            }
        }

        #endregion
    }
}
