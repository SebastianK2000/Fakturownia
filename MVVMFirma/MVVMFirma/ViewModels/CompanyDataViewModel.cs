using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System.Collections.Generic;
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
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Company Name", "First Name", "Last Name", "NIP", "REGON" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Company Name")
                List = new ObservableCollection<CompanyDataForAllView>(List.OrderBy(item => item.CompanyName));
            if (SortField == "First Name")
                List = new ObservableCollection<CompanyDataForAllView>(List.OrderBy(item => item.FirstNameCompanyOwner));
            if (SortField == "Last Name")
                List = new ObservableCollection<CompanyDataForAllView>(List.OrderBy(item => item.LastNameCompanyOwner));
            if (SortField == "NIP")
                List = new ObservableCollection<CompanyDataForAllView>(List.OrderBy(item => item.NIP));
            if (SortField == "REGON")
                List = new ObservableCollection<CompanyDataForAllView>(List.OrderBy(item => item.REGON));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Company Name", "First Name", "Last Name", "NIP" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Company Name")
                List = new ObservableCollection<CompanyDataForAllView>(List.Where(item => item.CompanyName != null && item.CompanyName.StartsWith(FindTextBox)));
            if (FindField == "First Name")
                List = new ObservableCollection<CompanyDataForAllView>(List.Where(item => item.FirstNameCompanyOwner != null && item.FirstNameCompanyOwner.StartsWith(FindTextBox)));
            if (FindField == "Last Name")
                List = new ObservableCollection<CompanyDataForAllView>(List.Where(item => item.LastNameCompanyOwner != null && item.LastNameCompanyOwner.StartsWith(FindTextBox)));
            if (FindField == "NIP")
            {
                if (int.TryParse(FindTextBox, out int NIP))
                {
                    List = new ObservableCollection<CompanyDataForAllView>(
                        List.Where(item => item.NIP == NIP)
                    );
                }
            }
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<CompanyDataForAllView>
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
        }
        #endregion
    }
}
