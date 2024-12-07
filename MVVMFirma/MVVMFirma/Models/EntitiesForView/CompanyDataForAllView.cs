using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class CompanyDataForAllView
    {
        public int IdCompanyData {  get; set; }
        public string TypeOfActivity { get; set; }
        public string CompanyName { get; set; }
        public string FirstNameCompanyOwner { get; set; }
        public string LastNameCompanyOwner { get; set; }
        public decimal? NIP { get; set; }
        public decimal? REGON { get; set; }
        public string AdressCity { get; set; }
        public string AdressStreet { get; set; }
        public string AdressNrHome { get; set; }
        public string AdressNrLocal { get; set; }
        public string AdressZipCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
    }
}
