using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class NotificationsAddViewModel : JedenViewModel<Notifications>
    {
        #region Construktor
        public NotificationsAddViewModel()
            : base("Notifications")
        {
            Item = new Notifications();
        }

        #endregion

        #region Properties
        public string Message
        {
            get
            {
                return Item.Message;
            }
            set
            {
                Item.Message = value;
                OnPropertyChanged(() => Message);
            }
        }
        public DateTime? SendDate
        {
            get
            {
                return Item.SendDate;
            }
            set
            {
                Item.SendDate = value;
                OnPropertyChanged(() => SendDate);
            }
        }
        public int? IdCustomer
        {
            get
            {
                return Item.IdCustomer;
            }
            set
            {
                Item.IdCustomer = value;
                OnPropertyChanged(() => IdCustomer);
            }
        }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            invoiceEntities.Notifications.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
