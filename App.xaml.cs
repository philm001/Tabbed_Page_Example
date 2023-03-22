namespace Tabbed_Page;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}
