using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class ImportViewModel:WszystkieViewModel<ImportExportLogs>
    {
        #region Construktor
        public ImportViewModel()
            : base("Import")
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