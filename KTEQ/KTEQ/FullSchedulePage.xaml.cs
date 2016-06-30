using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KTEQ
{
	public partial class FullSchedulePage : ContentPage
	{
		public FullSchedulePage()
		{
			InitializeComponent();
		}

		async void OnBackButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}

