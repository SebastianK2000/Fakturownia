using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class KontrahentViewModel:WszystkieViewModel<KontrahentForAllView>
    {
        #region Constructor
        public KontrahentViewModel()
            : base("Kontrahent")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KontrahentForAllView>
            (
                from kontrahent in invoiceEntities.Kontrahent
                select new KontrahentForAllView
                {
                    IdKontrahent = kontrahent.IdKontrachenta,
                    Code = kontrahent.Code,
                    NIP = kontrahent.NIP,
                    Name = kontrahent.Name,
                    KindName = kontrahent.Kind.Name,
                    StatusName = kontrahent.Status.Name,
                    AdressStreet = kontrahent.Adress.Street,
                    AdressCity = kontrahent.Adress.City,
                    AdressNrHome = kontrahent.Adress.NrHome,
                    AdressNrLocal = kontrahent.Adress.NrLocal,
                    AdressZipCode = kontrahent.Adress.ZipCode,
                }
            );
        }
        #endregion
    }
}
