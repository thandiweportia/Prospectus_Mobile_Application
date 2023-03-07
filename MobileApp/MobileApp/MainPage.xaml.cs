﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About_CTU));
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Apply_Online));
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Why_CTU));
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Courses));
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Activities));
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Location));
        }
    }

}
