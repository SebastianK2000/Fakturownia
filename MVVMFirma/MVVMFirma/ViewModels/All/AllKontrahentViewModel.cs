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
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class AllKontrahentViewModel : WszystkieViewModel<Kontrahent>
    {
        #region Construktor

        public AllKontrahentViewModel()
            : base("Kontrahenci")
        {
        }
        #endregion
        private BaseCommand _ShowKontrahent;
        #region Properties
        // do tego propertisa zostanie przypisany Kontrahent kliknięty na liście
        private Kontrahent _SelectedKontrahent;
        public Kontrahent SelectedKontrahent
        {
            get
            {
                return _SelectedKontrahent;
            }
            set
            {
                _SelectedKontrahent = value;
                Messenger.Default.Send(_SelectedKontrahent);
                OnRequestClose();
            }
        }
        #endregion
            #region Command
        public ICommand ShowKontrahent
        {
            get
            {
                if (_ShowKontrahent == null)
                    _ShowKontrahent = new BaseCommand(() => showKontrahenci());
                return _ShowKontrahent;
            }
        }
        private void showKontrahenci()
        {
            Messenger.Default.Send<string>("KontrahentAll");
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
                List = new ObservableCollection<Kontrahent>(List.OrderBy(item => item.Code));
            if (SortField == "NIP")
                List = new ObservableCollection<Kontrahent>(List.OrderBy(item => item.NIP));
            if (SortField == "Name")
                List = new ObservableCollection<Kontrahent>(List.OrderBy(item => item.Name));
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
                List = new ObservableCollection<Kontrahent>(List.Where(item => item.Code != null && item.Code.StartsWith(FindTextBox)));
            if (FindField == "NIP")
                List = new ObservableCollection<Kontrahent>(List.Where(item => item.NIP != null && item.NIP.StartsWith(FindTextBox)));
            if (FindField == "Name")
                List = new ObservableCollection<Kontrahent>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Kontrahent>
                (
                    invoiceEntities.Kontrahent.ToList()
                );
        }
        #endregion
    }
}
