using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class NowyTowarViewModel : JedenViewModel<Towar>
    {

        #region Construktor
        public NowyTowarViewModel()
            :base("Towar")
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
            invoiceEntities.Towar.Add(Item); // dodaje do lokalnej kolekcji
            invoiceEntities.SaveChanges(); // zapisuje do DB
        }
        #endregion

    }
}
