using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class CustomersRaportViewModel:WszystkieViewModel<CustomerRaport>
    {
        #region Construktor

        public CustomersRaportViewModel()
            : base("Raport Cutomer")
        {
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "IdCustomerRaport" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "IdCustomerRaport")
                List = new ObservableCollection<CustomerRaport>(List.OrderBy(item => item.IdCustomerRaport));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "IdCustomerRaport" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "IdCustomerRaport")
            {
                if (int.TryParse(FindTextBox, out int IdCustomerRaport))
                {
                    List = new ObservableCollection<CustomerRaport>(
                        List.Where(item => item.IdCustomerRaport == IdCustomerRaport)
                    );
                }
            }
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<CustomerRaport>
                (
                    invoiceEntities.CustomerRaport.ToList()
                );
        }
        #endregion
    }
}