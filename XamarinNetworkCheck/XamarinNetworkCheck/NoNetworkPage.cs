using System;
using Xamarin.Forms;

namespace XamarinRESTClient
{
    class NoNetworkPage : ContentPage
    {
        public NoNetworkPage()
        {
            BackgroundColor = Color.FromRgb(0xFF, 0x10, 0x10);
            Content = new Label()
            {
                Text = "Connessione non disponibile",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromRgb(0xFF, 0xFF, 0xFF),
            };
        }
    }
}
