using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Helper;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;
using MVVMFirma.Views;

namespace MVVMFirma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion

        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }
        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
    {

        // Customer section

        new CommandViewModel(
            "Add New Customer",
            new BaseCommand(() => this.CreateView(new CustomerViewModel()))),

        new CommandViewModel(
            "Customer List",
            new BaseCommand(() => this.ShowView<CustomersListViewModel>())),

        new CommandViewModel(
            "Customer Archive",
            new BaseCommand(() => this.ShowView<CustomerHistoryViewModel>())),

        new CommandViewModel(
            "Kontrahent",
            new BaseCommand(() => this.ShowView<KontrahentViewModel>())),

        // Invoices section

        new CommandViewModel(
            "Add New Invoice",
            new BaseCommand(() => this.CreateView(new NewInvoiceViewModel()))),

        new CommandViewModel(
            "Invoices List",
            new BaseCommand(() => this.ShowView<InvoiceAllViewModel>())),

        new CommandViewModel(
            "Status",
            new BaseCommand(() => this.ShowView<StatusViewModel>())),

        // Products and Services section

        new CommandViewModel(
            "Add New Product",
            new BaseCommand(() => this.CreateView(new NowyTowarViewModel()))),

        new CommandViewModel(
            "Product List",
            new BaseCommand(() => this.ShowView<WszystkieTowaryViewModel>())),

        // Raport and analiza section 

        new CommandViewModel(
            "Sales Raport",
            new BaseCommand(() => this.CreateView(new SalesRaportViewModel()))),

        new CommandViewModel(
            "Customers Raport",
            new BaseCommand(() => this.CreateView(new CustomersRaportViewModel()))),

        new CommandViewModel(
            "Vat Raport",
            new BaseCommand(() => this.CreateView(new VatViewModel()))),

        // Notifications and configurations section

        new CommandViewModel(
            "Company Data",
            new BaseCommand(() => this.ShowView<CompanyDataViewModel>())),

        new CommandViewModel(
            "Notifications",
            new BaseCommand(() => this.ShowView<NotificationsViewModel>())),

        // Payments section 

        new CommandViewModel(
            "Payments",
            new BaseCommand(() => this.ShowView<PaymentViewModel>())),

        new CommandViewModel(
            "Payment Method",
            new BaseCommand(() => this.ShowView<SettlementsViewModel>())),

        // Organizational section

        new CommandViewModel(
            "Import",
            new BaseCommand(() => this.ShowView<ImportViewModel>())),

        new CommandViewModel(
            "Export",
            new BaseCommand(() => this.ShowView<ExportViewModel>())),

        new CommandViewModel(
            "Help",
            new BaseCommand(() => this.ShowView<HelpViewModel>())),

        new CommandViewModel(
            "Contact Support",
            new BaseCommand(() => this.ShowView<ContactSupportViewModel>())),

        new CommandViewModel(
            "Settings",
            new BaseCommand(() => this.ShowView<SettingsViewModel>()))
    };
        }

        #endregion

        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }

        #endregion // Workspaces

        #region Private Helpers
        private void CreateView(WorkspaceViewModel New) // Element create new
        {
            //NowyTowarViewModel workspace = new NowyTowarViewModel(); // tworzenie zakładki
            this.Workspaces.Add(New); // dodanie zakładki do kolekcji zakładek
            this.SetActiveWorkspace(New); // aktywowanie zakładki
        }

        //private void CreateInvoice()
        //{
        //    NewInvoiceViewModel workspace = new NewInvoiceViewModel();
        //    this.Workspaces.Add(workspace);
        //    this.SetActiveWorkspace(workspace);
        //}

        private void ShowView<T>() where T : WorkspaceViewModel, new() // Element show 
        {
            T workspace = this.Workspaces.OfType<T>().FirstOrDefault();

            if (workspace == null)
            {
                workspace = new T();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
        #endregion
    }
}
