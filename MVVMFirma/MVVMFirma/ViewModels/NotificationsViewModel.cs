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
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Id Notification", "Message" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Id Notification")
                List = new ObservableCollection<NotificationsForAllView>(List.OrderBy(item => item.IdNotification));
            if (SortField == "Message")
                List = new ObservableCollection<NotificationsForAllView>(List.OrderBy(item => item.Message));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Id Notification", "Message" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Id Notification")
            {
                if (int.TryParse(FindTextBox, out int IdNotification))
                {
                    List = new ObservableCollection<NotificationsForAllView>(
                        List.Where(item => item.IdNotification == IdNotification)
                    );
                }
            }
            if (FindField == "Message")
                List = new ObservableCollection<NotificationsForAllView>(List.Where(item => item.Message != null && item.Message.StartsWith(FindTextBox)));
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