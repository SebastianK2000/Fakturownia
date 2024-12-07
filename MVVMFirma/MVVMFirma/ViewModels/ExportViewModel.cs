using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class ExportViewModel:WszystkieViewModel<ImportExportLogsForAllView>
    {
        #region Construktor
        public ExportViewModel()
            : base("Export")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ImportExportLogsForAllView>
                (
                    from logs in invoiceEntities.ImportExportLogs
                    select new ImportExportLogsForAllView
                    {
                        IdLog = logs.IdLog,
                        ActionType = logs.ActionType,
                        FileName = logs.FileName,
                        Timestamp = logs.Timestamp,
                        InvoiceNumber = logs.Invoice.Number,
                    }
                );
        }
        #endregion
    }
}