using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class StatusViewModel:WszystkieViewModel<Status>
    {
        #region Constructor
        public StatusViewModel()
            : base("Status")
        {
            Load();
        }
        #endregion
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "IdStatus", "Name" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (List == null) return;

            if (SortField == "IdStatus")
                List = new ObservableCollection<Status>(List.OrderBy(item => item.IdStatus));
            else if (SortField == "Name")
                List = new ObservableCollection<Status>(List.OrderBy(item => item.Name));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Name" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (List == null)
            {
                return;
            }

            if (FindField == "Name")
                List = new ObservableCollection<Status>(List.Where(item => item.Name != null && item.Name.StartsWith(FindTextBox)));
        }
        #endregion
        #region Properties
        public ObservableCollection<Status> StatusList { get; set; }
        public ObservableCollection<Kind> KindList { get; set; }
        #endregion

        #region Helpers
        public override void Load()
        {
            StatusList = new ObservableCollection<Status>(
            invoiceEntities.Status.ToList()
            );

            KindList = new ObservableCollection<Kind>(
                invoiceEntities.Kind.ToList()
            );
        }
        #endregion
    }
}
