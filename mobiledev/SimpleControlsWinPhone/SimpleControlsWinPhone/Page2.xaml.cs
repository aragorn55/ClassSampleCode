using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SimpleControlsWinPhone
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                string sData;
                NavigationContext.QueryString.TryGetValue("info", out sData);
                tbInfo.Text = sData;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            base.OnNavigatedTo(e);
        }
        private void lblForward_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }
    }
}