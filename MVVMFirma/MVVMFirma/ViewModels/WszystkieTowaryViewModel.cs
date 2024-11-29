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
    public class WszystkieTowaryViewModel : WorkspaceViewModel
    {
        #region DB
        private readonly InvoiceEntities invoiceEntities; // pole preprezentujące DB
        #endregion

        #region LoadCommand
        private BaseCommand _LoadCommand; // komenda wywołująca funkcje pobierania z DB

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new BaseCommand(() => load());
                return _LoadCommand;
            }
        }

        #endregion

        #region List
        private ObservableCollection<Towar> _List; // Tu przechowujemy towary pobrane z DB

        public ObservableCollection<Towar> List
        {
            get
            {
                if (_List == null)
                    load();
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


        public WszystkieTowaryViewModel()
        {
            base.DisplayName = "Towary";
            invoiceEntities = new InvoiceEntities();

        }
        #endregion

        #region Helpers
        // metoda load pobierze all towary z DB
        private void load()
        {
            List = new ObservableCollection<Towar>
                (
                    invoiceEntities.Towar.ToList() // pobieramy z DB towar i zamieniamy na listę
                );
        }
        #endregion
    }
}