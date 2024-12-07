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
    public class SettingsViewModel : WszystkieViewModel<SettingsForAllView>
    {
        #region Constructor
        public SettingsViewModel()
            : base("Settings")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<SettingsForAllView>
            (
                from settings in invoiceEntities.Settings
                select new SettingsForAllView
                {
                    IdSettings = settings.IdSettings,
                    Languge = settings.Language,
                    Login = settings.Login,
                    Password = settings.Password,
                    PaymentDeadlineTrigger = settings.PaymentDeadlineTrigger,
                    NewInvoiceTrigger = settings.NewInoviceTrigger,
                    PaymentNotMade = settings.PymentNotMade,
                    CustomerName = settings.Customer.Name,
                    CustomerEmail = settings.Customer.Email,
                    CustomerPhone = settings.Customer.Phone,
                }
            );
        }
        #endregion
    }
}
