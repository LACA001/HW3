﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3partOne
{
	public partial class Plan1 : ContentPage
	{
		public Plan1 (string houseOptExist)
		{
			InitializeComponent ();

            planType.Text = houseOptExist;
		}
	}
}