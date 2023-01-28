using Composite.Models;
namespace Composite.Views;

public partial class TreeListPAge : ContentPage
{
	public TreeListPAge()
	{
		InitializeComponent();
        List<Trees> trees = App.TreeRepo.GetAllTrees();
        treesList.ItemsSource = trees;

    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TreesItemPage));
    }


}