using MVVMFirma.Helper;
using MVVMFirma.Models.BusinessLogic;
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
    public class SalesRaportViewModel:WorkspaceViewModel
    {
        #region DB
        InvoiceEntities db;
        #endregion
        #region Construktor

        public SalesRaportViewModel()
        {
            base.DisplayName = "Sales Raport";
            db=new InvoiceEntities();
            DataOd=DateTime.Now;
            DataDo=DateTime.Now;
            Utarg = 0;
        }
        #endregion
        #region Fields
        // pola do obliczeń
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
        private decimal? _Utarg;
        public decimal? Utarg
        {
            get
            {
                return _Utarg;
            }
            set
            {
                if (_Utarg != value)
                {
                    _Utarg = value;
                    OnPropertyChanged(() => Utarg);
                }
            }
        }
        // properties który uzupełni all towary w comboboxie
        public IQueryable<KeyAndValue> TowaryItems
        {
            get
            {
                return new TowarB(db).GetTowaryKeyAndValueItems();
            }
        }
        #endregion
        #region Command
        // komenda która zostanie podpięta pod przycisk OBLICZ oraz wywoła funkcję obliczUtarg
        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                    _ObliczCommand = new BaseCommand(() => obliczUtargClick());
                return _ObliczCommand;
            }
        }
        private void obliczUtargClick()
        {
            Utarg = new UtargB(db).UtargOkresTowar(IdTowar, DataOd, DataDo);
        }
        #endregion
    }
}