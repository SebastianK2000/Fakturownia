using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class ExportViewModel:WszystkieViewModel<ImportExportLogs>
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
            List = new ObservableCollection<ImportExportLogs>
                (
                    invoiceEntities.ImportExportLogs.ToList()
                );
        }
        #endregion
    }
}