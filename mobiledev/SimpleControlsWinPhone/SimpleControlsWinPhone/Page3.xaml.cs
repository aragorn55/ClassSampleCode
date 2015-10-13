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
    public partial class Page3 : PhoneApplicationPage
    {
        public CPerson Person;
        public Page3()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            tbPerson.Text = Person.Firstname + " " + Person.Lastname;
            base.OnNavigatedTo(e);
        }
        private void lblBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }
    }
}