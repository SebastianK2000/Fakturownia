using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using MVVMFirma.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyTowarViewModel : JedenViewModel<Towar>, IDataErrorInfo
    {

        #region Construktor
        public NowyTowarViewModel()
            :base("New Towar")
        {
            Item = new Towar();
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

        public decimal? PurchaseRate
        {
            get
            {
                return Item.PurchaseRate;
            }
            set
            {
                Item.PurchaseRate = value;
                OnPropertyChanged(() => PurchaseRate);
            }
        }

        public decimal? SalesRate
        {
            get
            {
                return Item.SalesRate;
            }
            set
            {
                Item.SalesRate = value;
                OnPropertyChanged(() => SalesRate);
            }
        }

        public decimal? Price
        {
            get
            {
                return Item.Price;
            }
            set
            {
                Item.Price = value;
                OnPropertyChanged(() => Price);
            }
        }

        public decimal? Spread
        {
            get
            {
                return Item.Spread;
            }
            set
            {
                Item.Spread = value;
                OnPropertyChanged(() => Spread);
            }
        }

        public string Notes
        {
            get
            {
                return Item.Notes;
            }
            set
            {
                Item.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Nie można zapisać danych. Upewnij się, że wszystkie pola są poprawne.");
            }
            invoiceEntities.Towar.Add(Item); // dodaje do lokalnej kolekcji
            invoiceEntities.SaveChanges(); // zapisuje do DB
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
                if (propertyName == nameof(PurchaseRate))
                {
                    _validateMessage = BusinessValidator.ValidateIsPositive(PurchaseRate);
                }
                if (propertyName == nameof(SalesRate))
                {
                    _validateMessage = BusinessValidator.ValidateIsPositive(SalesRate);
                }
                if (propertyName == nameof(Price))
                {
                    _validateMessage = BusinessValidator.ValidateIsPositive(Price);
                }
                if (propertyName == nameof(Spread))
                {
                    _validateMessage = BusinessValidator.ValidateIsPositive(Spread);
                }
                return _validateMessage;
            }
        }

        public override bool IsValid()
        {
            var propertiesToValidate = new[] { nameof(Name), nameof(PurchaseRate), nameof(SalesRate), nameof(Price), nameof(Spread) };
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
