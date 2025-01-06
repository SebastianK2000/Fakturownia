using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
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
