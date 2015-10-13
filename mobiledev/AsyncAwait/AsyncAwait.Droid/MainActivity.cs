using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Org.Apache.Http.Client.Params;
using System.Net.Http;
using System.IO;
using Android.Media;
using Android.Graphics;


namespace AsyncAwait.Droid
{
	[Activity (Label = "AsyncAwait.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		Button GetButton;
		TextView ResultTextView;
		EditText ResultEditText;
		ImageView DownloadedImageView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			GetButton = FindViewById<Button> (Resource.Id.GetButton);
			ResultTextView = FindViewById<TextView> (Resource.Id.ResultTextView);
			ResultEditText = FindViewById<EditText> (Resource.Id.ResultEditText);
			DownloadedImageView = FindViewById<ImageView> (Resource.Id.DownloadedImageView);

			GetButton.Click += async (sender, e) => {
				
				Task<int> sizeTask = DownloadHomePageAsync();

				ResultTextView.Text = "Loading...";
				ResultEditText.Text = "Loading...\n";

				DownloadedImageView.SetImageResource ( Android.Resource.Drawable.IcMenuGallery);

				var length = await sizeTask;

				ResultTextView.Text = "length:  " + length;

			};

		}

		public async Task<int> DownloadHomePageAsync ()
		{
			var httpClient = new HttpClient ();

			Task<string> contentsTask = httpClient.GetStringAsync("http://xamarin.com/");

			string contents = await contentsTask;

			ResultEditText.Text += "DownloadedHomepage method continues after the async call.\n";

			int exampleInt = contents.Length;

			ResultEditText.Text += "Downloaded the html and found the length. \n\n\n";

			//Deal with an image
			Byte[] imageBytes = await httpClient.GetByteArrayAsync("http://xamaring.com/images/about/team.jpg");


			// Store it on the device
			string documentPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);

			string localFileName = "team.jpg";
			string localPath = System.IO.Path.Combine (documentPath, localFileName);

			File.WriteAllBytes (localPath, imageBytes);


			ResultEditText.Text += "Downloaded the image. \n";

			var localImage = new Java.IO.File (localPath);
			if (localImage.Exists ()) {
				var teamBitmap = BitmapFactory.DecodeFile (localImage.AbsolutePath);
				DownloadedImageView.SetImageBitmap (teamBitmap);

			}
			ResultEditText.Text += contents;
			return exampleInt;



		}
	}
}


