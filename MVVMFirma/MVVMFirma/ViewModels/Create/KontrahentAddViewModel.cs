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
                OnPropertyChanged(() => IdKind); // musze dodać plik kindB
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
                OnPropertyChanged(() => IdAdress);// musze dodać plik AddressB
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
                OnPropertyChanged(() => IdStatus);// musze dodać plik StatusB
            }
        }
        #endregion
        #region Propertises for ComboBox 
        public IQueryable<KeyAndValue> KontrahentItems
        {
            get
            {
                return new KontrahenciB(invoiceEntities).GetKontrahenciKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> CustomerItems
        {
            get
            {
                return new CustomersB(invoiceEntities).GetCustomersKeyAndValueItems();
            }
        }
        public IQueryable<KeyAndValue> PaymentMethodItems
        {
            get
            {
                return new PaymentMethodB(invoiceEntities).GetPaymentMethodKeyAndValueItems();
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
