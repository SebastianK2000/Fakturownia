using MVVMFirma.Models.BusinessLogic;
using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using MVVMFirma.Validators;
using System;
using System.Linq;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using MVVMFirma.Helper;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class CustomerArchiveAddViewModel : JedenViewModel<Customer>, IDataErrorInfo
    {
        #region Constructor
        public CustomerArchiveAddViewModel()
            : base("Customer Archive")
        {
            Item = new Customer();
        }
        #endregion
        #region Command
        private BaseCommand _CancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new BaseCommand(() => CancelAndClose());
                return _CancelCommand;
            }
        }
        #endregion
        #region Properties
        public string Name
        {
            get => Item.Name;
            set
            {
                Item.Name = value;
                OnPropertyChanged(() => Name);
            }
        }

        public string Phone
        {
            get => Item.Phone;
            set
            {
                Item.Phone = value;
                OnPropertyChanged(() => Phone);
            }
        }

        public string Email
        {
            get => Item.Email;
            set
            {
                Item.Email = value;
                OnPropertyChanged(() => Email);
            }
        }

        public string Notes
        {
            get => Item.Notes;
            set
            {
                Item.Notes = value;
                OnPropertyChanged(() => Notes);
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            if (string.IsNullOrWhiteSpace(Item.Name) || string.IsNullOrWhiteSpace(Item.Email))
            {
                Console.WriteLine("Name i Email są wymagane.");
                return;
            }

            invoiceEntities.Customer.Add(Item);
            invoiceEntities.SaveChanges();
        }

        // Cancel method
        public override void Cancel()
        {
            Item = new Customer();
        }

        public void CancelAndClose()
        {
            Cancel();

            base.OnRequestClose();
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
                if (propertyName == nameof(Email))
                {
                    _validateMessage = EmailValidator.ValidateEmail(Email);
                }
                return _validateMessage;
            }
        }
        public override bool IsValid()
        {
            var propertiesToValidate = new[] { nameof(Name), nameof(Email) };
            foreach (var property in propertiesToValidate)
            {
                if (!string.IsNullOrEmpty(this[property]))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
