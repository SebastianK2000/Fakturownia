using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class AllAddressViewModel : WszystkieViewModel<Adress>
    {
        #region Construktor

        public AllAddressViewModel()
            : base("Address")
        {
        }
        #endregion
        #region Properties
        // do tego propertisa zostanie przypisany Kontrahent kliknięty na liście
        private Adress _SelectedAdress;
        public Adress SelectedAdress
        {
            get
            {
                return _SelectedAdress;
            }
            set
            {
                _SelectedAdress = value;
                Messenger.Default.Send(_SelectedAdress);
                OnRequestClose();
            }
        }
        #endregion
        #region Command
        private BaseCommand _ShowCustomers;

        public ICommand ShowCustomers
        {
            get
            {
                if (_ShowCustomers == null)
                    _ShowCustomers = new BaseCommand(() => showCustomers());
                return _ShowCustomers;
            }
        }
        private void showCustomers()
        {
            Messenger.Default.Send<string>("AddressAll");
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "City", "Street", "ZipCode"};
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "City")
                List = new ObservableCollection<Adress>(List.OrderBy(item => item.City));
            if (SortField == "Street")
                List = new ObservableCollection<Adress>(List.OrderBy(item => item.Street));
            if (SortField == "ZipCode")
                List = new ObservableCollection<Adress>(List.OrderBy(item => item.ZipCode));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "City", "Street", "ZipCode" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "City")
                List = new ObservableCollection<Adress>(List.Where(item => item.City != null && item.City.StartsWith(FindTextBox)));
            if (FindField == "Street")
                List = new ObservableCollection<Adress>(List.Where(item => item.Street != null && item.Street.StartsWith(FindTextBox)));
            if (FindField == "ZipCode")
                List = new ObservableCollection<Adress>(List.Where(item => item.ZipCode != null && item.ZipCode.StartsWith(FindTextBox)));
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Adress>
                (
                    invoiceEntities.Adress.ToList()
                );
        }
        #endregion
    }
}
