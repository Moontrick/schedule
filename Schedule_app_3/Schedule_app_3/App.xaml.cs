namespace Schedule_app_3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
        {
            MainPage = new NavigationPage(new IndexPage("", ""));

        }
        else
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
