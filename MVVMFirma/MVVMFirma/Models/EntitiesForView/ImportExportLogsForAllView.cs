using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class ImportExportLogsForAllView
    {
        public int IdLog { get; set; }
        public string ActionType { get; set; }
        public string FileName { get; set; }
        public DateTime? Timestamp { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
