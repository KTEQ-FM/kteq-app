using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KTEQ
{
	public partial class SchedulePage : ContentPage
	{
		public SchedulePage()
		{
			InitializeComponent();
		}

		async void OnFullScheduleButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new FullSchedulePage());
		}
	}
}

