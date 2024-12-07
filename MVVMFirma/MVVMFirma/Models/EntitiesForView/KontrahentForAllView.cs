using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class KontrahentForAllView
    {
        public int IdKontrahent {  get; set; }
        public string Code { get; set; }
        public string NIP { get; set; }
        public string Name { get; set; }
        public string KindName { get; set; }
        public string StatusName { get; set; }
        public string AdressStreet { get; set; }
        public string AdressCity { get; set; }
        public string AdressNrHome { get; set; }
        public string AdressNrLocal { get; set; }
        public string AdressZipCode { get; set; }
    }
}
