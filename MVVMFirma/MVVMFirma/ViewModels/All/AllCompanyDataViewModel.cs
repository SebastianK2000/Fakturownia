﻿using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class AllCompanyDataViewModel : WszystkieViewModel<CompanyData>
    {
        #region Construktor

        public AllCompanyDataViewModel()
            : base("Company Data")
        {
        }
        #endregion
        #region Properties
        // do tego propertisa zostanie przypisany Kontrahent kliknięty na liście
        private CompanyData _SelectedCompanyData;
        public CompanyData SelectedCompanyData
        {
            get
            {
                return _SelectedCompanyData;
            }
            set
            {
                _SelectedCompanyData = value;
                Messenger.Default.Send(_SelectedCompanyData);
                OnRequestClose();
            }
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
            Messenger.Default.Send<string>("CompanyDataAll");
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
                List = new ObservableCollection<CompanyData>(List.OrderBy(item => item.CompanyName));
            if (SortField == "First Name")
                List = new ObservableCollection<CompanyData>(List.OrderBy(item => item.FirstNameCompanyOwner));
            if (SortField == "Last Name")
                List = new ObservableCollection<CompanyData>(List.OrderBy(item => item.LastNameCompanyOwner));
            if (SortField == "NIP")
                List = new ObservableCollection<CompanyData>(List.OrderBy(item => item.NIP));
            if (SortField == "REGON")
                List = new ObservableCollection<CompanyData>(List.OrderBy(item => item.REGON));
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
                List = new ObservableCollection<CompanyData>(List.Where(item => item.CompanyName != null && item.CompanyName.StartsWith(FindTextBox)));
            if (FindField == "First Name")
                List = new ObservableCollection<CompanyData>(List.Where(item => item.FirstNameCompanyOwner != null && item.FirstNameCompanyOwner.StartsWith(FindTextBox)));
            if (FindField == "Last Name")
                List = new ObservableCollection<CompanyData>(List.Where(item => item.LastNameCompanyOwner != null && item.LastNameCompanyOwner.StartsWith(FindTextBox)));
            if (FindField == "NIP")
            {
                if (int.TryParse(FindTextBox, out int NIP))
                {
                    List = new ObservableCollection<CompanyData>(
                        List.Where(item => item.NIP == NIP)
                    );
                }
            }

        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<CompanyData>
                (
                    invoiceEntities.CompanyData.ToList()
                );
        }
        #endregion
    }
}
