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
    public class KontrahentAddViewModel : JedenViewModel<Kontrahent>
    {
        #region Construktor
        public KontrahentAddViewModel()
            : base("Kontrahent")
        {
            Item = new Kontrahent();
        }

        #endregion

        #region Properties
        public string Code
        {
            get
            {
                return Item.Code;
            }
            set
            {
                Item.Code = value;
                OnPropertyChanged(() => Code);
            }
        }
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
        public string NIP
        {
            get
            {
                return Item.NIP;
            }
            set
            {
                Item.NIP = value;
                OnPropertyChanged(() => NIP);
            }
        }
        public int? IdKind
        {
            get
            {
                return Item.IdKind;
            }
            set
            {
                Item.IdKind = value;
                OnPropertyChanged(() => IdKind);
            }
        }
        public int? IdAdress
        {
            get
            {
                return Item.IdAdress;
            }
            set
            {
                Item.IdAdress = value;
                OnPropertyChanged(() => IdAdress);
            }
        }
        public int? IdStatus
        {
            get
            {
                return Item.IdStatus;
            }
            set
            {
                Item.IdStatus = value;
                OnPropertyChanged(() => IdStatus);
            }
        }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> KindItems
        {
            get
            {
                return new KindB(invoiceEntities).GetKindKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> AddressItems
        {
            get
            {
                return new AddressB(invoiceEntities).GetAddressKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> StatusItems
        {
            get
            {
                return new StatusB(invoiceEntities).GetStatusKeyAndValueItems();
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            invoiceEntities.Kontrahent.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
    }
}
