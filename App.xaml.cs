using Composite.Data;
namespace Composite;

public partial class App : Application
{
    public static TreeDatabase TreeRepo { get; set; }

    public App(TreeDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		TreeRepo = repo;
	}
}
