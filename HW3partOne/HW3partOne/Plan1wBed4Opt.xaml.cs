using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3partOne
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Plan1wBed4Opt : ContentPage
	{
		public Plan1wBed4Opt (string houseOptExist)
		{
			InitializeComponent ();
            Plan1Bed4Opt.Text = houseOptExist;

        }
	}
}