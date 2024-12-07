using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class AddressForAllView
    {
        public int IdAdress { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NrHome { get; set; }
        public string NrLocal { get; set; }
        public string ZipCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
    }
}
