using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class ImportViewModel:WszystkieViewModel<ImportExportLogsForAllView>
    {
        #region Construktor
        public ImportViewModel()
            : base("Import")
        {
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Id Log", "Invoice Number" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Id Log")
                List = new ObservableCollection<ImportExportLogsForAllView>(List.OrderBy(item => item.IdLog));
            if (SortField == "Invoice Number")
                List = new ObservableCollection<ImportExportLogsForAllView>(List.OrderBy(item => item.InvoiceNumber));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Id Log", "Invoice Number" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Id Log")
            {
                if (int.TryParse(FindTextBox, out int IdLog))
                {
                    List = new ObservableCollection<ImportExportLogsForAllView>(
                        List.Where(item => item.IdLog == IdLog)
                    );
                }
            }
            if (FindField == "Invoice Number")
                List = new ObservableCollection<ImportExportLogsForAllView>(List.Where(item => item.InvoiceNumber != null && item.InvoiceNumber.StartsWith(FindTextBox)));
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