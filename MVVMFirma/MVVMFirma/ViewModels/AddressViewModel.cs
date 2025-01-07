using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class AddressViewModel:WszystkieViewModel<AddressForAllView>
    {
        #region Constructor
        public AddressViewModel()
            : base("Address")
        {
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "City", "Street", "ZipCode", "Customer Email" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "City")
                List = new ObservableCollection<AddressForAllView>(List.OrderBy(item => item.City));
            if (SortField == "Street")
                List = new ObservableCollection<AddressForAllView>(List.OrderBy(item => item.Street));
            if (SortField == "ZipCode")
                List = new ObservableCollection<AddressForAllView>(List.OrderBy(item => item.ZipCode));
            if (SortField == "Customer Email")
                List = new ObservableCollection<AddressForAllView>(List.OrderBy(item => item.CustomerEmail));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "City", "Street", "ZipCode", "Customer Email" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "City")
                List = new ObservableCollection<AddressForAllView>(List.Where(item => item.City != null && item.City.StartsWith(FindTextBox)));
            if (FindField == "Street")
                List = new ObservableCollection<AddressForAllView>(List.Where(item => item.Street != null && item.Street.StartsWith(FindTextBox))); 
            if (FindField == "ZipCode")
                List = new ObservableCollection<AddressForAllView>(List.Where(item => item.ZipCode != null && item.ZipCode.StartsWith(FindTextBox)));
            if (FindField == "Customer Email")
                List = new ObservableCollection<AddressForAllView>(List.Where(item => item.CustomerEmail != null && item.CustomerEmail.StartsWith(FindTextBox)));
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<AddressForAllView>
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