using System;
using UIKit;


namespace TabDemo.UI
{
	public class TabController : UITabBarController
	{
		// Declare the tab
		UIViewController tab1, tab2, tab3;

		public TabController ()
		{
			tab1 = new UIViewController ();
			tab1.Title = "Blue";
			tab1.TabBarItem = new UITabBarItem (UITabBarSystemItem.Favorites, 0);
			tab1.View.BackgroundColor = UIColor.Blue;

			tab2 = new UIViewController ();
			tab2.Title = "Yellow";
			tab2.TabBarItem = new UITabBarItem ();
			tab2.TabBarItem.Image = UIImage.FromBundle ("images/Ghostbusters.png");
			tab2.View.BackgroundColor = UIColor.Yellow;

			tab3 = new UIViewController ();
			tab3.Title = "Red";
			tab3.View.BackgroundColor = UIColor.Red;

			var tabs = new UIViewController[] {
				tab1, tab2, tab3
			};
			ViewControllers = tabs;
		}
	}
}

