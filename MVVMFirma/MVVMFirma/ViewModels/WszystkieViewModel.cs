using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region DB
        protected readonly InvoiceEntities invoiceEntities; // pole preprezentujące DB
        #endregion

        #region Command
        private BaseCommand _LoadCommand; // komenda wywołująca funkcje pobierania z DB

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new BaseCommand(() => Load());
                return _LoadCommand;
            }
        }
        private BaseCommand _AddCommand; // komenda wywołująca funkcje add wywołującą okno do dodawania

        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                    _AddCommand = new BaseCommand(() => Add());
                return _AddCommand;
            }
        }

        #endregion

        #region List
        private ObservableCollection<T> _List; // Tu przechowujemy towary pobrane z DB

        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    Load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List); // Odświeżenie listy na interfejsie
            }
        }
        #endregion

        #region Construktor


        public WszystkieViewModel(String displayName)
        {
            invoiceEntities = new InvoiceEntities();
            base.DisplayName = displayName;
        }
        #endregion
        #region Sort & filtr
        // do sortowania
        // wynuk wyboru po czym sortować zostanie zapisany w SortField
        public string SortField { get; set; }
        public List<string> SortComboboxItems
        {
            get
            {
                return GetComboboxSortList();
            }
        }
        public abstract List<string> GetComboboxSortList();
        private BaseCommand _SortCommand; // komenda wywołująca funkcje sortowania po naciśnięciu sortuj
        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                    _SortCommand = new BaseCommand(() => Sort());
                return _SortCommand;
            }
        }
        public abstract void Sort();

        // do filtrowania
        public string FindField { get; set; }
        public List<string> FindComboboxItems
        {
            get
            {
                return GetComboboxFindList();
            }
        }
        public abstract List<string> GetComboboxFindList();
        public string FindTextBox { get; set; }
        private BaseCommand _FindCommand; // komenda wywołująca funkcje po naciśnięciu szukaj
        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                    _FindCommand = new BaseCommand(() => Find());
                return _FindCommand;
            }
        }
        public abstract void Find();
        #endregion
        #region Helpers

        public abstract void Load();
        public void Add()
        {
            // ten komunikat odbierze mainViewModel i wyświetli okno do dodawania
            Messenger.Default.Send(DisplayName + "Add");
        }
        #endregion
    }
}
