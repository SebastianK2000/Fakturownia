using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class NotificationsForAllView
    {
        public int IdNotification { get; set; }
        public string Message { get; set; }
        public int CustomerIdCustomer {  get; set; }
        public string CustomerName { get; set; }
        public DateTime? SendDate { get; set; }
    }
}
