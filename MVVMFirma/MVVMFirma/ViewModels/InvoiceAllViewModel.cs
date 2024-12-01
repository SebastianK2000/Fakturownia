﻿using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class InvoiceAllViewModel:WszystkieViewModel<Invoice>
    {

        #region Constructor
        public InvoiceAllViewModel()
            : base("Customer")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Invoice>(
                invoiceEntities.Invoice.ToList()
            );
        }
        #endregion
    }
}

