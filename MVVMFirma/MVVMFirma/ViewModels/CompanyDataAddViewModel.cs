using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels.Create
{
    public class CompanyDataAddViewModel : JedenViewModel<CompanyData>
    {
        #region Construktor
        public CompanyDataAddViewModel()
            : base("Company Data")
        {
            Item = new CompanyData();
        }

        #endregion

        #region Properties
        public string TypeOfActivity
        {
            get
            {
                return Item.TypeOfActivity;
            }
            set
            {
                Item.TypeOfActivity = value;
                OnPropertyChanged(() => TypeOfActivity);
            }
        }
        public string CompanyName
        {
            get
            {
                return Item.CompanyName;
            }
            set
            {
                Item.CompanyName = value;
                OnPropertyChanged(() => CompanyName);
            }
        }
        public string FirstNameCompanyOwner
        {
            get
            {
                return Item.FirstNameCompanyOwner;
            }
            set
            {
                Item.FirstNameCompanyOwner = value;
                OnPropertyChanged(() => FirstNameCompanyOwner);
            }
        }
        public string LastNameCompanyOwner
        {
            get
            {
                return Item.LastNameCompanyOwner;
            }
            set
            {
                Item.LastNameCompanyOwner = value;
                OnPropertyChanged(() => LastNameCompanyOwner);
            }
        }
        public decimal? NIP
        {
            get
            {
                return Item.NIP;
            }
            set
            {
                Item.NIP = value;
                OnPropertyChanged(() => NIP);
            }
        }
        public decimal? REGON
        {
            get
            {
                return Item.REGON;
            }
            set
            {
                Item.REGON = value;
                OnPropertyChanged(() => REGON);
            }
        }
        public int? IdCustomer
        {
            get
            {
                return Item.IdCustomer;
            }
            set
            {
                Item.IdCustomer = value;
                OnPropertyChanged(() => IdCustomer);
            }
        }
        public int? IdAdress
        {
            get
            {
                return Item.IdAdress;
            }
            set
            {
                Item.IdAdress = value;
                OnPropertyChanged(() => IdAdress);
            }
        }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> AddressItems
        {
            get
            {
                return new AddressB(invoiceEntities).GetAddressKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            invoiceEntities.CompanyData.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
