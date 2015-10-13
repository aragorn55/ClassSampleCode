using System;
using Xamarin.Forms;

namespace WorkingWithBehaviors
{
	public class App : Application
	{
		public App ()
		{
			var xamlTab = new TabbedPage ();
			xamlTab.Children.Add (new NumericValidationXaml{Title = "Numeric", Icon = "icon.png" });
			MainPage = xamlTab;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

