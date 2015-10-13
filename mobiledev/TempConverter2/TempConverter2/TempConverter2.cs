using System;

using Xamarin.Forms;
using TempConverterPro.PCL;

namespace TempConverter2
{
	public class App : Application
	{
		Label oLabel;
		Entry oEntry;

		public App ()
		{
			//Create individual controls
			oLabel = new Label{
				XAlign = TextAlignment.Center,
				Text = "Enter a Temp to convert",
				FontAttributes = FontAttributes.Bold,
				FontSize = 35
			
			};
			oEntry = new Entry {
				Text = "Temp"
			};
			Button oButton = new Button {
			Font = Font.SystemFontOfSize (NamedSize.Large),
				BorderWidth = 1,
				BorderRadius = 3,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				FontAttributes = FontAttributes.Bold,
				Text = "Convert"
			};
			oButton.Clicked += OnButtonClicked;
			// add them to container
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.StartAndExpand,
					BackgroundColor = Color.FromHex ("6495ed"),
					Children =  {
						oLabel,
						oEntry,
						oButton
					}
				}
			};

		}

		void OnButtonClicked (object sender, EventArgs e)
		{
			double dblTemp = Convert.ToDouble (oEntry.Text);
			oLabel.Text = CTempConvert.ConvertToFahrenheit (dblTemp).ToString ("N2");
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

