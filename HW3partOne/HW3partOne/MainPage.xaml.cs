using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW3partOne
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
		}

        async void Plan1Clicked(object sender, EventArgs e)
        {
            string response = await DisplayActionSheet("Plan 1 Variation", "Cancel", null,"Standard", "with Bed 4 Option");

            if(response.Equals("Standard", StringComparison.OrdinalIgnoreCase))
            {
                await Navigation.PushAsync(new Plan1("Standard Plan 1"));
            }

            if (response.Equals("with Bed 4 Option", StringComparison.OrdinalIgnoreCase))
            {
                await Navigation.PushAsync(new Plan1wBed4Opt("Plan 1 with Bed 4 Option"));
            }
        }

        void Plan2Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Plan2());
        }

        void Plan3Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Plan3());
        }
    }
}
