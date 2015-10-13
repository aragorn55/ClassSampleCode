// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyFirstApp.UI
{
	[Register ("MyFirstApp_UIViewController")]
	partial class MyFirstApp_UIViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnClick { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnDouble { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblClicks { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblStatus { get; set; }

		[Action ("btnClick_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnClick_TouchUpInside (UIButton sender);

		[Action ("btnDouble_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnDouble_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnClick != null) {
				btnClick.Dispose ();
				btnClick = null;
			}
			if (btnDouble != null) {
				btnDouble.Dispose ();
				btnDouble = null;
			}
			if (lblClicks != null) {
				lblClicks.Dispose ();
				lblClicks = null;
			}
			if (lblStatus != null) {
				lblStatus.Dispose ();
				lblStatus = null;
			}
		}
	}
}
