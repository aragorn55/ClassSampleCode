using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace TempConverter2
{
	public class uiEBookCView : ContentView
	{
		Label moTitle = new Label();
		Label moDesc = new Label();
		Label moTags = new Label();
		public uiEBookCView ()
		{
			Content = new Label { Text = "Hello ContentView" };
		}
		public uiEBookCView (List<string> oTitles, List<string> oDescriptions, List<string> oTags)
		{
			moTitle.Text = oTitles [0];
			moDesc.Text = oDescriptions [0];
			foreach (var item in oTags) {
				moTags.Text += item + ", ";
			}

			Content = new Label { Text = "Hello ContentView" };
		}
		public bool SetStyle()
		{
			moTitle.FontAttributes = FontAttributes.Bold;
			return true;
		}
	}
}


