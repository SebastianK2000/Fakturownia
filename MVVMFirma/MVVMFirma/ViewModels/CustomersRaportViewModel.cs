using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using System;
using System.Linq;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class CustomersRaportViewModel : WorkspaceViewModel
    {
        #region DB
        InvoiceEntities db;
        #endregion

        #region Constructor
        public CustomersRaportViewModel()
        {
            base.DisplayName = "Customers Raport";
            db = new InvoiceEntities();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
        }
        #endregion

        #region Fields
        private DateTime _DataOd;
        public DateTime DataOd
        {
            get { return _DataOd; }
            set
            {
                if (_DataOd != value)
                {
                    _DataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }

        private DateTime _DataDo;
        public DateTime DataDo
        {
            get { return _DataDo; }
            set
            {
                if (_DataDo != value)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }

        private int _AllNewCustomers;
        public int AllNewCustomers
        {
            get { return _AllNewCustomers; }
            set
            {
                if (_AllNewCustomers != value)
                {
                    _AllNewCustomers = value;
                    OnPropertyChanged(() => AllNewCustomers);
                }
            }
        }
        #endregion

        #region Command
        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                    _ObliczCommand = new BaseCommand(() => ObliczNewCustomers());
                return _ObliczCommand;
            }
        }

        private void ObliczNewCustomers()
        {
            var customersB = new CustomersB(db);
            AllNewCustomers = customersB.GetNewCustomersCount(DataOd, DataDo);
        }
        #endregion
    }
}
