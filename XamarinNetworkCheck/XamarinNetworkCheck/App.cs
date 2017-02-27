using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using Xamarin.Forms;

namespace XamarinRESTClient
{
    public class App : Application
    {
        public App()
        {
            CrossConnectivity.Current.ConnectivityChanged += OnConnectivityChanged;

            if (CrossConnectivity.Current.IsConnected)
                MainPage = new NetworkInfoPage();
            else
                MainPage = new NoNetworkPage();
        }

        private void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs connectivityChangedEventArgs)
        {
            if (connectivityChangedEventArgs.IsConnected)
                MainPage = new NetworkInfoPage();
            else
                MainPage = new NoNetworkPage();
        }

        // ...

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
