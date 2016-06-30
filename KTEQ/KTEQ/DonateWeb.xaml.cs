using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KTEQ
{
	public partial class DonateWeb : ContentPage
	{
		public DonateWeb()
		{

			//Take the user to the Foundation Page
			var browser = new WebView
			{
				Source = "https://foundation.sdsmt.edu/giving/donate-now"
			};
			Content = browser;

		}
	}
}

