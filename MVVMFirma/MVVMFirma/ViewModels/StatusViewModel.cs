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
