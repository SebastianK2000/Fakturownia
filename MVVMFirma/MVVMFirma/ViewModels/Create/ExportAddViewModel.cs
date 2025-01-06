using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class ExportAddViewModel : JedenViewModel<ImportExportLogs>
    {
        #region Construktor
        public ExportAddViewModel()
            : base("Export")
        {
            Item = new ImportExportLogs();
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
        public string ActionType
        {
            get
            {
                return Item.ActionType;
            }
            set
            {
                Item.ActionType = value;
                OnPropertyChanged(() => ActionType);
            }
        }
        public string FileName
        {
            get
            {
                return Item.FileName;
            }
            set
            {
                Item.FileName = value;
                OnPropertyChanged(() => FileName);
            }
        }
        public DateTime? Timestamp
        {
            get
            {
                return Item.Timestamp;
            }
            set
            {
                Item.Timestamp = value;
                OnPropertyChanged(() => Timestamp);
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
        public override void Save()
        {
            invoiceEntities.ImportExportLogs.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
