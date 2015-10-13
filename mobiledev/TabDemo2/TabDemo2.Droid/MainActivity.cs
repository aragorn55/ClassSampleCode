using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TabDemo2.Droid
{
	[Activity (Label = "TabDemo2.Droid", MainLauncher = true, Icon = "@drawable/icon", Theme="@android:style/Theme.NoTitleBar")]
	public class MainActivity : TabActivity
	{
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			TabHost.TabSpec spec; //Reuseable tabspec for each tab.
			Intent intent; //Reuseable intent for each tab.
			//create an intent to launch an activity for the tab
			intent = new Intent(this, typeof(ArtistsActivity));
				
			//research
			intent.AddFlags (ActivityFlags.NewTask);

			//initialize a tabspec for each tab.

			spec = TabHost.NewTabSpec ("artists");
			spec.SetIndicator ("Artists", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			intent = new Intent(this, typeof(AlbumsActivity));

			//research
			intent.AddFlags (ActivityFlags.NewTask);

			//initialize a tabspec for each tab.

			spec = TabHost.NewTabSpec ("albums");
			spec.SetIndicator ("Albums", Resources.GetDrawable(Resource.Drawable.ic_tab_albums));
			spec.SetContent (intent);
			TabHost.AddTab (spec);
			intent = new Intent(this, typeof(SongsActivity));

			//research
			intent.AddFlags (ActivityFlags.NewTask);

			//initialize a tabspec for each tab.

			spec = TabHost.NewTabSpec ("songs");
			spec.SetIndicator ("Songs", Resources.GetDrawable(Resource.Drawable.ic_tab_songs));
			spec.SetContent (intent);
			TabHost.AddTab (spec);
			TabHost.CurrentTab = 1;
		}
	}
}


