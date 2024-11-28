using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class CustomerViewModel:WorkspaceViewModel
    {
        public CustomerViewModel()
        {
            base.DisplayName = "Customer";
        }
    }
}
