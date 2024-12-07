using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class SettingsForAllView
    {
        public int IdSettings {  get; set; }
        public string Languge {  get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool? PaymentDeadlineTrigger { get; set; }
        public bool? NewInvoiceTrigger { get; set; }
        public bool? PaymentNotMade { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}
