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
    public abstract class WszystkieViewModel<T>:WorkspaceViewModel
    {
        #region DB
        protected readonly InvoiceEntities invoiceEntities; // pole preprezentujące DB
        #endregion

        #region LoadCommand
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

        #region Helpers

        public abstract void Load();

        #endregion
    }
}
