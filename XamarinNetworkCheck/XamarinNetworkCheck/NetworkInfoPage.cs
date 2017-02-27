using System;
using System.Linq;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using Xamarin.Forms;

namespace XamarinRESTClient
{
    class NetworkInfoPage : ContentPage
    {
        private Label lblConnectionDetails;

        public NetworkInfoPage()
        {
            lblConnectionDetails = new Label()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                TextColor = Color.FromRgb(0x00, 0xA0, 0x00),
            };

            BackgroundColor = Color.FromRgb(0xB0, 0xB0, 0xB0);
            Content = lblConnectionDetails;

            SetConnectionDetails();

            CrossConnectivity.Current.ConnectivityTypeChanged += OnConnectivityTypeChanged;
        }

        private void OnConnectivityTypeChanged(object sender, ConnectivityTypeChangedEventArgs connectivityTypeChangedEventArgs)
        {
            SetConnectionDetails();
        }

        private void SetConnectionDetails()
        {
            lblConnectionDetails.Text = string.Format("{0}", CrossConnectivity.Current.ConnectionTypes.FirstOrDefault());
        }
    }
}
