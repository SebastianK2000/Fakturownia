using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels.Create
{
    public class StatusAddViewModel : JedenViewModel<Status>
    {
        #region Construktor
        public StatusAddViewModel()
            : base("Status")
        {
            Item = new Status();
        }

        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return Item.Name;
            }
            set
            {
                Item.Name = value;
                OnPropertyChanged(() => Name);
            }
        }
        public string Description
        {
            get
            {
                return Item.Description;
            }
            set
            {
                Item.Description = value;
                OnPropertyChanged(() => Description);
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            invoiceEntities.Status.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
