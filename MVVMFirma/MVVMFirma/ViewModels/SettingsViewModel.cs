using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class SettingsViewModel : WszystkieViewModel<Settings>
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
            List = new ObservableCollection<Settings>
            (
                invoiceEntities.Settings.ToList()
            );
        }
        #endregion
    }
}
