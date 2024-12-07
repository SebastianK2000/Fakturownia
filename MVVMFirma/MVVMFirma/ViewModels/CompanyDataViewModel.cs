using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class CompanyDataViewModel : WszystkieViewModel<CompanyDataForAllView>
    {
        #region Constructor
        public CompanyDataViewModel()
            : base("Company Data")
        {
        }
        #endregion

        #region Properties
        public ObservableCollection<CompanyDataForAllView> CompanyDataList { get; set; }
        public ObservableCollection<AddressForAllView> AdressList { get; set; }
        #endregion

        #region Helpers
        public override void Load()
        {
            CompanyDataList = new ObservableCollection<CompanyDataForAllView>
            (
                from company in invoiceEntities.CompanyData
                select new CompanyDataForAllView
                {
                    IdCompanyData = company.IdCompanyData,
                    CompanyName = company.CompanyName,
                    TypeOfActivity = company.TypeOfActivity,
                    FirstNameCompanyOwner = company.FirstNameCompanyOwner,
                    LastNameCompanyOwner = company.LastNameCompanyOwner,
                    NIP = company.NIP,
                    REGON = company.REGON,
                    AdressCity = company.Adress.City,
                    AdressStreet = company.Adress.Street,
                    AdressNrHome = company.Adress.NrHome,
                    AdressNrLocal = company.Adress.NrLocal,
                    AdressZipCode = company.Adress.ZipCode,
                    CustomerName = company.Customer.Name,
                    CustomerPhone = company.Customer.Phone,
                    CustomerEmail = company.Customer.Email,
                }
            );

            AdressList = new ObservableCollection<AddressForAllView>
            (
                from address in invoiceEntities.Adress
                select new AddressForAllView
                {
                    IdAdress = address.IdAdress,
                    City = address.City,
                    Street = address.Street,
                    NrHome = address.NrHome,
                    NrLocal = address.NrLocal,
                    ZipCode = address.ZipCode,
                    CustomerName = address.Customer.Name,
                    CustomerPhone = address.Customer.Phone,
                    CustomerEmail = address.Customer.Email,
                }
            );
        }
        #endregion
    }
}
