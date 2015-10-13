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

namespace SaveData.UI
{
	[Register ("SaveViewController")]
	partial class SaveViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSaveData1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		PickerDataViewModel pkrNames { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView SaveViewController { get; set; }

		[Action ("btnSaveData1_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSaveData1_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSaveData1 != null) {
				btnSaveData1.Dispose ();
				btnSaveData1 = null;
			}
			if (pkrNames != null) {
				pkrNames.Dispose ();
				pkrNames = null;
			}
			if (SaveViewController != null) {
				SaveViewController.Dispose ();
				SaveViewController = null;
			}
		}
	}
}
