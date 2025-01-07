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
    public class AllFakturyViewModel : WszystkieViewModel<Invoice>
    {
        #region Construktor

        public AllFakturyViewModel()
            : base("Invoices")
        {
        }
        #endregion
        #region Properties
        // do tego propertisa zostanie przypisany Kontrahent kliknięty na liście
        private Invoice _SelectedInvoice;
        public Invoice SelectedInvoice
        {
            get
            {
                return _SelectedInvoice;
            }
            set
            {
                _SelectedInvoice = value;
                Messenger.Default.Send(_SelectedInvoice);
                OnRequestClose();
            }
        }
        #endregion
        #region Command
        private BaseCommand _ShowInvoice;

        public ICommand ShowInvoice
        {
            get
            {
                if (_ShowInvoice == null)
                    _ShowInvoice = new BaseCommand(() => showInvoice());
                return _ShowInvoice;
            }
        }
        private void showInvoice()
        {
            Messenger.Default.Send<string>("InvoiceAll");
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Number", "Kontrahent NIP", "Kontrahent Nazwa" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Number")
                List = new ObservableCollection<Invoice>(List.OrderBy(item => item.Number));
            if (SortField == "Kontrahent NIP")
                List = new ObservableCollection<Invoice>(List.OrderBy(item => item.Kontrahent.NIP));
            if (SortField == "Kontrahent Nazwa")
                List = new ObservableCollection<Invoice>(List.OrderBy(item => item.Kontrahent.Name));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Number", "Kontrahent NIP", "Kontrahent Nazwa" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Number")
                List = new ObservableCollection<Invoice>(List.Where(item => item.Number != null && item.Number.StartsWith(FindTextBox)));
            if (FindField == "Kontrahent NIP")
                List = new ObservableCollection<Invoice>(List.Where(item => item.Kontrahent.NIP != null && item.Kontrahent.NIP.StartsWith(FindTextBox)));
            if (FindField == "Kontrahent Nazwa")
                List = new ObservableCollection<Invoice>(List.Where(item => item.Kontrahent.Name != null && item.Kontrahent.Name.StartsWith(FindTextBox)));
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Invoice>
                (
                    invoiceEntities.Invoice.ToList()
                );
        }
        #endregion
    }
}
