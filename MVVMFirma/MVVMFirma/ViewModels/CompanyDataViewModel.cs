using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class CompanyDataViewModel:WorkspaceViewModel
    {
        #region DB
        private readonly InvoiceEntities invoiceEntities;
        #endregion

        #region LoadCommand
        private BaseCommand _LoadCommand;

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new BaseCommand(() => load());
                return _LoadCommand;
            }
        }
        #endregion

        #region List 

        private ObservableCollection<CompanyData> _List;

        public ObservableCollection<CompanyData> List
        {
            get
            {
                if (_List == null)
                    load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }

        #endregion

        #region Construktor

        
        public CompanyDataViewModel()
        {
            base.DisplayName = "Company Data";
            invoiceEntities = new InvoiceEntities();
        }
        #endregion

        #region Helpers

        private void load()
        {
            List = new ObservableCollection<CompanyData>
                (
                    invoiceEntities.CompanyData.ToList()
                );
        }

        #endregion

    }
}
