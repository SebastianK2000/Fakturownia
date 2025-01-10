using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using MVVMFirma.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class KontrahentAddViewModel : JedenViewModel<Kontrahent>, IDataErrorInfo
    {
        #region Construktor
        public KontrahentAddViewModel()
            : base("Kontrahent")
        {
            Item = new Kontrahent();
            // Messenger oczekujący na kontrahenta z widoku gdzie są allKontrahenci
            Messenger.Default.Register<Adress>(this, getSelectedAdress);
        }

        #endregion
        #region Command
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
        public string Code
        {
            get
            {
                return Item.Code;
            }
            set
            {
                Item.Code = value;
                OnPropertyChanged(() => Code);
            }
        }
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
        public string NIP
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
        public int? IdKind
        {
            get
            {
                return Item.IdKind;
            }
            set
            {
                Item.IdKind = value;
                OnPropertyChanged(() => IdKind);
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
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNrHome { get; set; }
        public string AddressNrLocal { get; set; }
        public string AddressZipCode { get; set; }
        public int? IdStatus
        {
            get
            {
                return Item.IdStatus;
            }
            set
            {
                Item.IdStatus = value;
                OnPropertyChanged(() => IdStatus);
            }
        }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> KindItems
        {
            get
            {
                return new KindB(invoiceEntities).GetKindKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> AddressItems
        {
            get
            {
                return new AddressB(invoiceEntities).GetAddressKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> StatusItems
        {
            get
            {
                return new StatusB(invoiceEntities).GetStatusKeyAndValueItems();
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
        public override void Save()
        {
            invoiceEntities.Kontrahent.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
        #region Validation
        public string Error => string.Empty;
        private string _validateMessage = string.Empty;
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == nameof(Name))
                {
                    _validateMessage = StringValidator.ValidateIsFirstLetterUpper(Name);
                }
                return _validateMessage;
            }
        }
        public override bool IsValid()
        {
            return string.IsNullOrEmpty(_validateMessage);
        }
        #endregion
    }
}
