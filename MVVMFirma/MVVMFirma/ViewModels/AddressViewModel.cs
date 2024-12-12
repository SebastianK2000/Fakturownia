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