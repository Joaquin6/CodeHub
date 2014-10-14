using CodeHub.Core.ViewModels.Organizations;
using ReactiveUI;
using CodeHub.iOS.TableViewSources;

namespace CodeHub.iOS.Views.Organizations
{
    public class OrganizationsView : ReactiveTableViewController<OrganizationsViewModel>
    {
        public override void ViewDidLoad()
        {
            Title = "Organizations";

            base.ViewDidLoad();

            TableView.Source = new UserTableViewSource(TableView, ViewModel.Organizations);
            ViewModel.LoadCommand.ExecuteIfCan();
        }
	}
}

