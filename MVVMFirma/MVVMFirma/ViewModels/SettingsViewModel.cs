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
        #region Sort & Find
        // w tej funkcji decydujemy po czym sortować
        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Id Settings", "Login", "Customer Name", "Customer Email" };
        }
        // w tej funkcji decydujemy JAK sortować
        public override void Sort()
        {
            if (SortField == "Id Settings")
                List = new ObservableCollection<SettingsForAllView>(List.OrderBy(item => item.IdSettings));
            if (SortField == "Login")
                List = new ObservableCollection<SettingsForAllView>(List.OrderBy(item => item.Login));
            if (SortField == "Customer Name")
                List = new ObservableCollection<SettingsForAllView>(List.OrderBy(item => item.CustomerName));
            if (SortField == "Customer Email")
                List = new ObservableCollection<SettingsForAllView>(List.OrderBy(item => item.CustomerEmail));
        }
        // w tej funkcji decydujemy po czym wyszukiwać
        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Id Settings", "Login", "Customer Name", "Customer Email" };
        }
        // w tej funkcji decydujemy JAK wyszukiwać
        public override void Find()
        {
            if (FindField == "Id Settings")
            {
                if (int.TryParse(FindTextBox, out int IdSettings))
                {
                    List = new ObservableCollection<SettingsForAllView>(
                        List.Where(item => item.IdSettings == IdSettings)
                    );
                }
            }
            if (FindField == "Login")
                List = new ObservableCollection<SettingsForAllView>(List.Where(item => item.Login != null && item.Login.StartsWith(FindTextBox)));
            if (FindField == "Customer Name")
                List = new ObservableCollection<SettingsForAllView>(List.Where(item => item.CustomerName != null && item.CustomerName.StartsWith(FindTextBox)));
            if (FindField == "Customer Email")
                List = new ObservableCollection<SettingsForAllView>(List.Where(item => item.CustomerEmail != null && item.CustomerEmail.StartsWith(FindTextBox)));
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
