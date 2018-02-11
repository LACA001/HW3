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

        void Plan1Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Plan1());
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
