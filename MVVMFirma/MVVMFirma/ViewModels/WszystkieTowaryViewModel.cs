using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;
using System.Data.Entity.Infrastructure;

namespace MVVMFirma.ViewModels
{
    public class WszystkieTowaryViewModel : WszystkieViewModel<Towar>
    {

        #region Construktor


        public WszystkieTowaryViewModel()
            :base("Towary")
        {
        }
        #endregion

        #region Helpers
        // metoda load pobierze all towary z DB
        public override void Load()
        {
            List = new ObservableCollection<Towar>
                (
                    invoiceEntities.Towar.ToList() // pobieramy z DB towar i zamieniamy na listę
                );
        }
        #endregion
    }
}