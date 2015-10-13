using System;

using Xamarin.Forms;

namespace TempConverter2
{
	public class EBookShelf : ContentPage
	{
		Label uiTitle = new Label();
		Label uiDescription = new Label();
		Label uiTags = new Label();

		public EBookShelf ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


