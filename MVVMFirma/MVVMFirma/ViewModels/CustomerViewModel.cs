using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class CustomerViewModel:JedenViewModel<Customer>
    {
        #region Construktor
        public CustomerViewModel()
            : base("New Customer")
        {
            Item = new Customer();
        }

        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return Item.Name;
            }
            set
            {
                Item.Name = value;
                OnPropertyChanged(() => Name);
            }
        }
        public string Phone
        {
            get
            {
                return Item.Phone;
            }
            set
            {
                Item.Phone = value;
                OnPropertyChanged(() => Phone);
            }
        }
        public string Email
        {
            get
            {
                return Item.Email;
            }
            set
            {
                Item.Email = value;
                OnPropertyChanged(() => Email);
            }
        }
        public string Notes
        {
            get
            {
                return Item.Notes;
            }
            set
            {
                Item.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            invoiceEntities.Customer.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion

    }
}
