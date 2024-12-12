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
            TotalPrice = 0;
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
                    OnPropertyChanged(() => _DataDo);
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
                    OnPropertyChanged(() => _IdTowar);
                }
            }
        }
        private decimal? _TotalPrice;
        public decimal? TotalPrice
        {
            get
            {
                return _TotalPrice;
            }
            set
            {
                if (_TotalPrice != value)
                {
                    _TotalPrice = value;
                    OnPropertyChanged(() => _TotalPrice);
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
            Console.WriteLine($"IdTowar: {IdTowar}, DataOd: {DataOd}, DataDo: {DataDo}");
            TotalPrice = new UtargB(db).UtargOkresTowar(IdTowar, DataOd, DataDo);
            Console.WriteLine($"TotalPrice: {TotalPrice}");
        }

        #endregion
    }
}