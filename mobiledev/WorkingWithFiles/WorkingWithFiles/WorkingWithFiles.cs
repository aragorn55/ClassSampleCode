using System;

using Xamarin.Forms;

namespace WorkingWithFiles
{
	public class App : Application
	{
		public App ()
		{
			//
			var tabs = new TabbedPage();
			tabs.Children.Add (new LoadResourceText { Title = "Resource", Icon = "txt.png"});
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

