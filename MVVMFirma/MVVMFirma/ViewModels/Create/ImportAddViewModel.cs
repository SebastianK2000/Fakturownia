using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
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
    public class ImportAddViewModel : JedenViewModel<ImportExportLogs>
    {
        #region Construktor
        public ImportAddViewModel()
            : base("Import")
        {
            Item = new ImportExportLogs();
            ActionTypes = new ObservableCollection<string> {"Import", "Export" };
            // Messenger oczekujący na kontrahenta z widoku gdzie są allKontrahenci
            Messenger.Default.Register<Invoice>(this, getSelectedInvoice);
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
        #region Properties
        private ObservableCollection<string> _actionTypes;
        public ObservableCollection<string> ActionTypes
        {
            get { return _actionTypes; }
            set
            {
                _actionTypes = value;
                OnPropertyChanged(() => ActionTypes);
            }
        }

        public string ActionType
        {
            get { return Item.ActionType; }
            set
            {
                Item.ActionType = value;
                OnPropertyChanged(() => ActionType);
            }
        }
        public int? IdInvoice
        {
            get
            {
                return Item.IdInvoice;
            }
            set
            {
                Item.IdInvoice = value;
                OnPropertyChanged(() => IdInvoice);
            }
        }
        public string InvoiceNumber { get; set; }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> KontrahentItems
        {
            get
            {
                return new KontrahenciB(invoiceEntities).GetKontrahenciKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> InvoiceItems
        {
            get
            {
                return new InvoiceB(invoiceEntities).GetInvoiceKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        private void getSelectedInvoice(Invoice invoice)
        {
            IdInvoice = invoice.IdInvoice;
            InvoiceNumber = invoice.Number;
        }
        public override void Save()
        {
            invoiceEntities.ImportExportLogs.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
