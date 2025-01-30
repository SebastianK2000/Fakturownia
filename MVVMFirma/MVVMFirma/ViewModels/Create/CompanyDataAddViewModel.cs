using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using MVVMFirma.Validators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace MVVMFirma.ViewModels
{
    public class CompanyDataAddViewModel : JedenViewModel<CompanyData>, IDataErrorInfo
    {
        #region Construktor
        public CompanyDataAddViewModel()
            : base("Company Data")
        {
            Item = new CompanyData();
            Types = new ObservableCollection<string> { "B2B", "B2C", "C2B", "C2C", "B2G", "G2B", "B2B2C", "Freelance", "Consulting", "E-commerce", "Startup", "Small Business", 
                "Social Enterprise", "Non-profit", "Manufacturing", "Service Provider", "Online Business", "Retail", "Wholesale", "Franchise", "Subscription Model"};

            Messenger.Default.Register<Customer>(this, getSelectedCustomer);
            Messenger.Default.Register<Adress>(this, getSelectedAdress);
        }

        #endregion
        #region Command
        private BaseCommand _CancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new BaseCommand(() => CancelAndClose());
                return _CancelCommand;
            }
        }

        private BaseCommand _ShowCustomers;

        public ICommand ShowCustomers
        {
            get
            {
                if (_ShowCustomers == null)
                    _ShowCustomers = new BaseCommand(() => showCustomers());
                return _ShowCustomers;
            }
        }
        private void showCustomers()
        {
            Messenger.Default.Send<string>("CustomersAll");
        }

        private BaseCommand _ShowAddress;

        public ICommand ShowAddress
        {
            get
            {
                if (_ShowAddress == null)
                    _ShowAddress = new BaseCommand(() => showAddress());
                return _ShowAddress;
            }
        }
        private void showAddress()
        {
            Messenger.Default.Send<string>("AddressAll");
        }
        #endregion
        #region Properties
        private ObservableCollection<string> _types;
        public ObservableCollection<string> Types
        {
            get { return _types; }
            set
            {
                _types = value;
                OnPropertyChanged(() => Types);
            }
        }
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
        public string CustomerName { get; set; }
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
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNrHome { get; set; }
        public string AddressNrLocal { get; set; }
        public string AddressZipCode { get; set; }
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
        private void getSelectedAdress(Adress adress)
        {
            IdAdress = adress.IdAdress;
            AddressCity = adress.City;
            AddressStreet = adress.Street;
            AddressNrHome = adress.NrHome;
            AddressNrLocal = adress.NrLocal;
            AddressZipCode = adress.ZipCode;
        }
        private void getSelectedCustomer(Customer cutomer)
        {
            IdCustomer = cutomer.IdCustomer;
            CustomerName = cutomer.Name;
        }
        private bool _canCloseWindow = false;
        public override void Save()
        {
            if (!IsValid())
            {
                ShowMessageBox("Popraw wszystkie błędy przed zapisaniem danych.");
                _canCloseWindow = false;
                return;
            }

            var itemWithNIP = Item as CompanyData;

            if (itemWithNIP?.NIP == null)
            {
                ShowMessageBox("NIP nie może być pusty. Proszę wprowadzić poprawny NIP.");
                _canCloseWindow = false;
                return;
            }

            if (itemWithNIP?.REGON == null)
            {
                ShowMessageBox("REGON nie może być pusty. Proszę wprowadzić poprawny REGON.");
                _canCloseWindow = false;
                return;
            }

            var existingCompanyData = invoiceEntities.CompanyData.FirstOrDefault(cd => cd.NIP == itemWithNIP.NIP);
            if (existingCompanyData != null)
            {
                ShowMessageBox("Firma z tym NIP już istnieje.");
                _canCloseWindow = false;
                return;
            }

            invoiceEntities.CompanyData.Add(Item);
            invoiceEntities.SaveChanges();

            _canCloseWindow = true;
            base.OnRequestClose();
        }

        // Cancel method
        public override void Cancel()
        {
            Item = new CompanyData();
        }

        public void CancelAndClose()
        {
            Cancel();

            base.OnRequestClose();
        }

        #endregion
        #region Validation
        public string Error => string.Empty;
        private string _validateMessage = string.Empty;
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == nameof(FirstNameCompanyOwner))
                {
                    _validateMessage = StringValidator.ValidateIsFirstLetterUpper(FirstNameCompanyOwner);
                }
                if (propertyName == nameof(LastNameCompanyOwner))
                {
                    _validateMessage = StringValidator.ValidateIsFirstLetterUpper(LastNameCompanyOwner);
                }
                if (propertyName == nameof(NIP))
                {
                    _validateMessage = NIPValidator.ValidateNIP(NIP);
                }
                if (propertyName == nameof(REGON))
                {
                    _validateMessage = ValidateREGON.Validate(REGON);
                }
                return _validateMessage;
            }
        }
        public override bool IsValid()
        {
            var propertiesToValidate = new[]
            {
        nameof(FirstNameCompanyOwner),
        nameof(LastNameCompanyOwner),
        nameof(NIP),
        nameof(REGON)
    };

            foreach (var property in propertiesToValidate)
            {
                if (!string.IsNullOrEmpty(this[property]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
