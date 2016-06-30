using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KTEQ
{
	public partial class DonatePage : ContentPage
	{
		public DonatePage()
		{
			InitializeComponent();
		}

		async void OnDonateButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new DonateWeb());
		}
	}
}

