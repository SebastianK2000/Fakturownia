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
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Command;

namespace MVVMFirma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<RelayCommand> RelayCommands { get; set; }

        public MainWindowViewModel()
        {
            RelayCommands = new ObservableCollection<RelayCommand>
            {
                new RelayCommand(ExecuteCustomerCommand),
                new RelayCommand(ExecuteCustomerListCommand),
                new RelayCommand(ExecuteCustomerArchiveCommand),
                // Możesz dodać kolejne komendy tutaj...
            };
        }

        private void ExecuteCustomerCommand()
        {
            ShowView<CustomerViewModel>();
        }

        private void ExecuteCustomerListCommand()
        {
            ShowView<CustomersListViewModel>();
        }

        private void ExecuteCustomerArchiveCommand()
        {
            ShowView<CustomerHistoryViewModel>();
        }

        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkspaceViewModel> _Workspaces;

        // Komendy wywołujące widoki
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
            Messenger.Default.Register<string>(this, Open);
            return new List<CommandViewModel>
            {
                // Customer section
                new CommandViewModel("Customer List", new BaseCommand(() => this.ShowView<CustomersListViewModel>())),
                new CommandViewModel("Customer Archive", new BaseCommand(() => this.ShowView<CustomerHistoryViewModel>())),
                new CommandViewModel("Kontrahent", new BaseCommand(() => this.ShowView<KontrahentViewModel>())),
                
                // Invoices section
                new CommandViewModel("Invoices List", new BaseCommand(() => this.ShowView<InvoiceAllViewModel>())),
                new CommandViewModel("Status", new BaseCommand(() => this.ShowView<StatusViewModel>())),
                
                // Products and Services section
                new CommandViewModel("Product List", new BaseCommand(() => this.ShowView<WszystkieTowaryViewModel>())),
                
                // Notifications and configurations section
                new CommandViewModel("Address", new BaseCommand(() => this.ShowView<AddressViewModel>())),
                new CommandViewModel("Company Data", new BaseCommand(() => this.ShowView<CompanyDataViewModel>())),
                new CommandViewModel("Notifications", new BaseCommand(() => this.ShowView<NotificationsViewModel>())),
                
                // Payments section 
                new CommandViewModel("Payments", new BaseCommand(() => this.ShowView<PaymentViewModel>())),
                new CommandViewModel("Payment Method", new BaseCommand(() => this.ShowView<SettlementsViewModel>())),
                
                // Organizational section
                new CommandViewModel("Import", new BaseCommand(() => this.ShowView<ImportViewModel>())),
                new CommandViewModel("Export", new BaseCommand(() => this.ShowView<ExportViewModel>())),
                new CommandViewModel("Settings", new BaseCommand(() => this.ShowView<SettingsViewModel>())),
                new CommandViewModel("Contact Support", new BaseCommand(() => this.ShowView<ContactSupportViewModel>())),
                new CommandViewModel("Help", new BaseCommand(() => this.ShowView<HelpViewModel>())),
                
                // Reports
                new CommandViewModel("Sales Raport", new BaseCommand(() => this.CreateView(new SalesRaportViewModel()))),
                new CommandViewModel("Customers Raport", new BaseCommand(() => this.CreateView(new CustomersRaportViewModel()))),
                new CommandViewModel("Vat Raport", new BaseCommand(() => this.CreateView(new VatViewModel()))),
            };
        }

        // Workspaces
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
            this.Workspaces.Remove(workspace);
        }

        // Private helpers
        private void CreateView(WorkspaceViewModel New) // Element create new
        {
            this.Workspaces.Add(New); // dodanie zakładki do kolekcji zakładek
            this.SetActiveWorkspace(New); // aktywowanie zakładki
        }

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

        private void Open(string name)
        {
            Debug.WriteLine($"Otrzymano komunikat: {name}");

            if (name == "TowaryAdd")
                CreateView(new NowyTowarViewModel());

            if (name == "CustomersAdd")
                CreateView(new CustomerViewModel());

            if (name == "InvoicesAdd")
                CreateView(new NewInvoiceViewModel());

            if (name == "KontrahentAdd")
                CreateView(new KontrahentAddViewModel());

            if (name == "AddressAdd")
                CreateView(new AddressAddViewModel());

            if (name == "CustomerAdd")
                CreateView(new CustomerArchiveAddViewModel());

            if (name == "Company DataAdd")
                CreateView(new CompanyDataAddViewModel());

            if (name == "ImportAdd")
                CreateView(new ImportAddViewModel());

            if (name == "ExportAdd")
                CreateView(new ExportAddViewModel());

            if (name == "NotificationsAdd")
                CreateView(new NotificationsAddViewModel());

            if (name == "PaymentsAdd")
                CreateView(new PaymentsAddViewModel());

            if (name == "Payments MethodAdd")
                CreateView(new PaymentMethodAddViewModel());

            if (name == "SettingsAdd")
                CreateView(new SettingsAddViewModel());

            if (name == "StatusAdd")
                CreateView(new StatusAddViewModel());

            // Modal section
            if (name == "AddressAll")
                ShowView<AllAddressViewModel>();

            if (name == "CompanyDataAll")
                ShowView<AllCompanyDataViewModel>();

            if (name == "CustomersAll")
                ShowView<AllCustomerViewModel>();

            if (name == "InvoiceAll")
                ShowView<AllFakturyViewModel>();

            if (name == "KontrahentAll")
                ShowView<AllKontrahentViewModel>();
        }

    }
}
