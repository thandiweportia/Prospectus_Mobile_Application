using System;
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
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EC_Map : Page
    {
        public EC_Map()
        {
            this.InitializeComponent();
            {
                BasicGeoposition location = new BasicGeoposition();
                location.Latitude = -33.94507;
                location.Longitude = 25.5701;

                MapIcon mapIcon;
                mapIcon = new MapIcon();
                if (mapIcon != null)
                {
                    EC.MapElements.Remove(mapIcon);
                }
                mapIcon.Location = new Geopoint(location);
                mapIcon.Title = "CTU TRAINING SOLUTIONS PORT ELIZABETH CAMPUS";
                EC.MapElements.Add(mapIcon);
                EC.Center = new Geopoint(location);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void MyWebView_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }
    }
}
