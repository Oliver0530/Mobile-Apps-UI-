using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class Birds : ContentPage
    {
        public Birds()
        {
            InitializeComponent();

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://www.rspb.org.uk/birds-and-wildlife/wildlife-guides/bird-a-z/");
        }

        public async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BirdPages.BluePit());
        }

        public async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BirdPages.Page1());
        }

        public async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BirdPages.Page1());
        }


    }
}