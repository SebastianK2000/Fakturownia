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
    public class NotificationsViewModel:WszystkieViewModel<NotificationsForAllView>
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
            List = new ObservableCollection<NotificationsForAllView>
                (
                from notifications in invoiceEntities.Notifications
                select new NotificationsForAllView
                {
                    IdNotification = notifications.IdNotification,
                    Message = notifications.Message,
                    CustomerIdCustomer = notifications.Customer.IdCustomer,
                    CustomerName = notifications.Customer.Name,
                    SendDate = notifications.SendDate,
                }
                );
        }
        #endregion
    }
}