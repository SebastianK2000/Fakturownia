using MVVMFirma.Models.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMFirma.ViewModels
{
    public class CompanyDataViewModel : WszystkieViewModel<CompanyData>
    {
        #region Constructor
        public CompanyDataViewModel()
            : base("Company Data")
        {
            Load();
        }
        #endregion

        #region Properties
        public ObservableCollection<CompanyData> CompanyDataList { get; set; }
        public ObservableCollection<Adress> AdressList { get; set; }
        #endregion

        #region Helpers
        public override void Load()
        {
            CompanyDataList = new ObservableCollection<CompanyData>(
                invoiceEntities.CompanyData.ToList()
            );

            AdressList = new ObservableCollection<Adress>(
                invoiceEntities.Adress.ToList()
            );
        }
        #endregion
    }
}
