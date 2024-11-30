using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyTowarViewModel : WorkspaceViewModel
    {

        #region DB
        private InvoiceEntities invoiceEntities;
        #endregion
        #region Item
        private Towar towar;
        #endregion

        #region Command 
        // komenda która zostanie podpięta pod zapisz/zamknij
        private BaseCommand _SaveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => SaveAndClose());
                return _SaveCommand;
            }
        }
        #endregion

        #region Construktor
        public NowyTowarViewModel()
        {
            base.DisplayName = "Towar";
            invoiceEntities = new InvoiceEntities();
            towar = new Towar();
        }

        #endregion

        #region Properties
        public string Code
        {
            get
            {
                return towar.Code;
            }
            set
            {
                towar.Code = value;
                OnPropertyChanged(() => Code);
            }
        }

        public string Name
        {
            get
            {
                return towar.Name;
            }
            set
            {
                towar.Name = value;
                OnPropertyChanged(() => Name);
            }
        }

        public decimal? PurchaseRate
        {
            get
            {
                return towar.PurchaseRate;
            }
            set
            {
                towar.PurchaseRate = value;
                OnPropertyChanged(() => PurchaseRate);
            }
        }

        public decimal? SalesRate
        {
            get
            {
                return towar.SalesRate;
            }
            set
            {
                towar.SalesRate = value;
                OnPropertyChanged(() => SalesRate);
            }
        }

        public decimal? Price
        {
            get
            {
                return towar.Price;
            }
            set
            {
                towar.Price = value;
                OnPropertyChanged(() => Price);
            }
        }

        public decimal? Spread
        {
            get
            {
                return towar.Spread;
            }
            set
            {
                towar.Spread = value;
                OnPropertyChanged(() => Spread);
            }
        }

        public string Notes
        {
            get
            {
                return towar.Notes;
            }
            set
            {
                towar.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }
        #endregion
        #region Helpers
        public void Save()
        {
            invoiceEntities.Towar.Add(towar); // dodaje do lokalnej kolekcji
            invoiceEntities.SaveChanges(); // zapisuje do DB
        }
        public void SaveAndClose()
        {
            Save();
            base.OnRequestClose(); // zamknięcie zakładki
        }
        #endregion

    }
}
