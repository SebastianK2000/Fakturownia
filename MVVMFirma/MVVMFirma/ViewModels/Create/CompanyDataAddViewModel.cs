﻿using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class CompanyDataAddViewModel : JedenViewModel<CompanyData>
    {
        #region Construktor
        public CompanyDataAddViewModel()
            : base("Company Data")
        {
            Item = new CompanyData();
            // Messenger oczekujący na kontrahenta z widoku gdzie są allKontrahenci
            Messenger.Default.Register<Customer>(this, getSelectedCustomer);

            Messenger.Default.Register<Adress>(this, getSelectedAdress);
        }

        #endregion
        #region Command
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
        public override void Save()
        {
            invoiceEntities.CompanyData.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
