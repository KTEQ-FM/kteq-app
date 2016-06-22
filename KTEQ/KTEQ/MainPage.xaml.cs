using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KTEQ
{
  public partial class MainPage : ContentPage
  {
    int count = 0;

    public MainPage()
    {
      InitializeComponent();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
      count++;
      await MainGrid.TranslateTo(200, 300, 1000, Easing.Linear);
      streamLabel.Text = "Suh Dude " + count;
    }
  }
}

