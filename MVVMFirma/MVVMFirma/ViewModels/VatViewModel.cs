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

    public class VatViewModel:WorkspaceViewModel
    {
        #region DB
        InvoiceEntities db;
        #endregion
        #region Construktor
        public VatViewModel()
        {
            base.DisplayName = "Vat Raport";
            db = new InvoiceEntities();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
        }
        #endregion
        #region Fields
        private DateTime _DataOd;
        public DateTime DataOd
        {
            get
            {
                return _DataOd;
            }
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
            get
            {
                return _DataDo;
            }
            set
            {
                if (_DataDo != value)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }
        private int _IdTowar;
        public int IdTowar
        {
            get
            {
                return _IdTowar;
            }
            set
            {
                if (_IdTowar != value)
                {
                    _IdTowar = value;
                    OnPropertyChanged(() => IdTowar);
                }
            }
        }
        private decimal? _UtargVat;
        public decimal? UtargVat
        {
            get
            {
                return _UtargVat;
            }
            set
            {
                if (_UtargVat != value)
                {
                    _UtargVat = value;
                    OnPropertyChanged(() => UtargVat);
                }
            }
        }
        public IQueryable<KeyAndValue> TowaryItems
        {
            get
            {
                return new TowarB(db).GetTowaryKeyAndValueItems();
            }
        }
        #endregion
        #region Command
        private BaseCommand _ObliczVatCommand;
        public ICommand ObliczVatCommand
        {
            get
            {
                if (_ObliczVatCommand == null)
                    _ObliczVatCommand = new BaseCommand(() => obliczUtargVatClick());
                return _ObliczVatCommand;
            }
        }
        private void obliczUtargVatClick()
        {
            if (IdTowar <= 0)
            {
                UtargVat = null;
                // Możesz dodać komunikat o błędzie, jeśli chcesz.
                return;
            }

            UtargVat = new UtargBVat(db).ObliczVat(IdTowar, DataOd, DataDo);
        }
        #endregion
    }
}
