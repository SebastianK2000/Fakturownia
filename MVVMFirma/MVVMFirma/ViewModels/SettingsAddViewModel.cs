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
    public class SettingsAddViewModel : JedenViewModel<Settings>
    {
        #region Construktor
        public SettingsAddViewModel()
            : base("Settings")
        {
            Item = new Settings();
        }

        #endregion

        #region Properties
        public string Language
        {
            get
            {
                return Item.Language;
            }
            set
            {
                Item.Language = value;
                OnPropertyChanged(() => Language);
            }
        }
        public string Login
        {
            get
            {
                return Item.Login;
            }
            set
            {
                Item.Login = value;
                OnPropertyChanged(() => Login);
            }
        }
        public string Password
        {
            get
            {
                return Item.Password;
            }
            set
            {
                Item.Password = value;
                OnPropertyChanged(() => Password);
            }
        }
        public bool? PaymentDeadlineTrigger
        {
            get
            {
                return Item.PaymentDeadlineTrigger;
            }
            set
            {
                Item.PaymentDeadlineTrigger = value;
                OnPropertyChanged(() => PaymentDeadlineTrigger);
            }
        }
        public bool? NewInoviceTrigger
        {
            get
            {
                return Item.NewInoviceTrigger;
            }
            set
            {
                Item.NewInoviceTrigger = value;
                OnPropertyChanged(() => NewInoviceTrigger);
            }
        }
        public bool? PymentNotMade
        {
            get
            {
                return Item.PymentNotMade;
            }
            set
            {
                Item.PymentNotMade = value;
                OnPropertyChanged(() => PymentNotMade);
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
            invoiceEntities.Settings.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
