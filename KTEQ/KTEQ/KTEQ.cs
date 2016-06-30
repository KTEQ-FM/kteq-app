﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KTEQ
{
  //tryna make a real crappy streamer here
  public class Streamer : ContentPage
  {
    int count = 0;
    public Streamer()
    {
      var playButton = new Button
      {
        Text = "Play"
      };

      var playLabel = new Label
      {
        Text = "Hey duuuude"
      };

      var stackLayout = new StackLayout
      {
        Padding = 40,
        Spacing = 10
      };

      stackLayout.Children.Add(playButton);
      stackLayout.Children.Add(playLabel );

      playButton.Clicked += (sender, args) =>
      {
        count++;
        playLabel.Text = "" + count;
      };

      Content = stackLayout;
    }
  }
}

