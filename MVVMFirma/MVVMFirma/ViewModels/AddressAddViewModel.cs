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
    public class AddressAddViewModel : JedenViewModel<Adress>
    {
        #region Construktor
        public AddressAddViewModel()
            : base("Address")
        {
            Item = new Adress();
        }

        #endregion

        #region Properties
        public string City
        {
            get
            {
                return Item.City;
            }
            set
            {
                Item.City = value;
                OnPropertyChanged(() => City);
            }
        }
        public string Street
        {
            get
            {
                return Item.Street;
            }
            set
            {
                Item.Street = value;
                OnPropertyChanged(() => Street);
            }
        }
        public string NrHome
        {
            get
            {
                return Item.NrHome;
            }
            set
            {
                Item.NrHome = value;
                OnPropertyChanged(() => NrHome);
            }
        }
        public string NrLocal
        {
            get
            {
                return Item.NrLocal;
            }
            set
            {
                Item.NrLocal = value;
                OnPropertyChanged(() => NrLocal);
            }
        }
        public string ZipCode
        {
            get
            {
                return Item.ZipCode;
            }
            set
            {
                Item.ZipCode = value;
                OnPropertyChanged(() => ZipCode);
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
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            invoiceEntities.Adress.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
