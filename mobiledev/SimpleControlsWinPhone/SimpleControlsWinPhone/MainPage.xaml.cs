using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SimpleControlsWinPhone.Resources;

namespace SimpleControlsWinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var RootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            RootFrame.Navigated += RootFrame_Navigated;
           
            
            base.OnNavigatedTo(e);
        }

        void RootFrame_Navigated(object sender, NavigationEventArgs e)
        {
            try
            {
                var newPage3 = e.Content as Page3;
                CPerson oPerson = new CPerson();
                oPerson.Firstname = txtTextBox.Text;
                oPerson.Lastname = txtTextBox.Text;

                // Send person data to page 3
                newPage3.Person = oPerson;

            }
            catch (Exception)
            {
                
                
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Text = txtTextBox.Text;
        }

        private void chkSwitch_Checked(object sender, RoutedEventArgs e)
        {
            chkSwitch.Content = "On";
        }

        private void chkSwitch_Unchecked(object sender, RoutedEventArgs e)
        {
            chkSwitch.Content = "Off";
        }

        private void rbOne_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option One",
                "Option",
                MessageBoxButton.OKCancel);
        }

        private void rbTwo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option Two",
               "Option",
               MessageBoxButton.OKCancel);
        }

      //   Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("Images/a.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarButtonText;
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            ApplicationBar.MenuItems.Add(appBarMenuItem);
        }

        private void lblForward_Click(object sender, RoutedEventArgs e)
        {
            string sInfo = txtTextBox.Text;

            NavigationService.Navigate(new Uri("/Page2.xaml?info=" + sInfo , UriKind.Relative));
        }

        private void lblLast_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }
    }
}