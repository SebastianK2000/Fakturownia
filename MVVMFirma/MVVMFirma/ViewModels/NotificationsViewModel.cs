using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class NotificationsViewModel:WszystkieViewModel<Notifications>
    {
        #region Construktor


        public NotificationsViewModel()
            : base("Notifications")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Notifications>
                (
                    invoiceEntities.Notifications.ToList()
                );
        }
        #endregion
    }
}