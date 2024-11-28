using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class CustomersListViewModel:WorkspaceViewModel
    {
        public CustomersListViewModel() 
        {
            base.DisplayName = "Customers List";
        }
    }
}
