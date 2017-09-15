using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App12
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(BlankPage));
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button button = sender as Button;
            switch(int.Parse(button.Tag.ToString()))
            {
                case 0:
                    (Application.Current.Resources["GridColorSolidBrush"] as SolidColorBrush).Color = Colors.Green;
                    break;
                case 1:
                    (Application.Current.Resources["GridColorSolidBrush"] as SolidColorBrush).Color = Colors.Gray;
                    break;
            }
        }
    }
}
