﻿using MVVMFirma.Helper;
using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public abstract class JedenViewModel<T> : WorkspaceViewModel
    {
        #region DB
        protected InvoiceEntities invoiceEntities; // pole preprezentujące DB
        #endregion
        #region Item
        protected T Item;
        #endregion
        #region Command
        private BaseCommand _SaveCommand;
        private BaseCommand _CancelCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => SaveAndClose());
                return _SaveCommand;
            }
        }

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
        #region Construktor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;
            invoiceEntities = new InvoiceEntities();
        }
        #endregion
        #region Helpers
        public abstract void Save();
        public void SaveAndClose()
        {
            if (IsValid())
            {
                Save();
                base.OnRequestClose();
            }
            else
            {
                ShowMessageBox("Popraw błędy aby zapisać.");
            }

        }
        public abstract void Cancel();
        public void CancelAndClose()
        {
            Cancel();
            base.OnRequestClose();
        }
        #endregion

        public virtual bool IsValid() => true;
    }
}
