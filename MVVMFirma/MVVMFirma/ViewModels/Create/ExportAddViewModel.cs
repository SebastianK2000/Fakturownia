using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels.Create
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
                return new KontrahenciB(invoiceEntities).GetKontrahenciKeyAndValueItems(); // tu do poprawy na invoice
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
