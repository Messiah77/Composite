using Composite.Models;
using Composite.Data;

namespace Composite.Views;

public partial class TreesItemPage : ContentPage
{
    Trees Item = new Trees();

    public TreesItemPage()
	{
		InitializeComponent();
	}

    private void OnSaveClicked(object sender, EventArgs e)
    {
        Item.NameComposite = nameB.Text;
        Item.NameLeaf = descB.Text;
        App.TreeRepo.AddNewTree(Item);
        Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }



}