
﻿namespace Schedule_app_3;

namespace Schedule_app_3;

using Microsoft.Maui.Networking;

public partial class App : Application
{


    public App()
    {

        InitializeComponent();
        var path = FileSystem.Current.AppDataDirectory;
        var fullPath = Path.Combine(path, "Shedule.txt");
        var fi = new FileInfo(fullPath);
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;


        if (!(accessType == NetworkAccess.Internet))
        {
            if (fi.Exists == false)
            {
                //переход куда то 
                MainPage = new NavigationPage(new MainPage());

            }
            else
                MainPage = new NavigationPage(new IndexPage("", ""));

        }
        else
        {
            if (fi.Exists == false)
            {
                MainPage = new NavigationPage(new FactPage());

            }
            else
                MainPage = new NavigationPage(new IndexPage("", ""));

        }

    }
}