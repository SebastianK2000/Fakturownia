using GalaSoft.MvvmLight.Messaging;
using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class AllKontrahentViewModel : WszystkieViewModel<Kontrahent>
    {
        #region Construktor

        public AllKontrahentViewModel()
            : base("Kontrahenci")
        {
        }
        #endregion
        private BaseCommand _ShowKontrahent;
        #region Command
        public ICommand ShowKontrahent
        {
            get
            {
                if (_ShowKontrahent == null)
                    _ShowKontrahent = new BaseCommand(() => showKontrahenci());
                return _ShowKontrahent;
            }
        }
        private void showKontrahenci()
        {
            Messenger.Default.Send<string>("KontrahentAll");
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Kontrahent>
                (
                    invoiceEntities.Kontrahent.ToList()
                );
        }
        #endregion
    }
}
