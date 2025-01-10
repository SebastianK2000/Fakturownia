using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using MVVMFirma.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class PaymentMethodAddViewModel : JedenViewModel<PaymentMethod>, IDataErrorInfo
    {
        #region Construktor
        public PaymentMethodAddViewModel()
            : base("Payment Method")
        {
            Item = new PaymentMethod();
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
            invoiceEntities.PaymentMethod.Add(Item);
            invoiceEntities.SaveChanges();
        }
        #endregion
        #region Validation
        public string Error => string.Empty;
        private string _validateMessage = string.Empty;
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == nameof(Name))
                {
                    _validateMessage = StringValidator.ValidateIsFirstLetterUpper(Name);
                }
                return _validateMessage;
            }
        }
        public override bool IsValid()
        {
            return string.IsNullOrEmpty(_validateMessage);
        }
        #endregion
    }
}
