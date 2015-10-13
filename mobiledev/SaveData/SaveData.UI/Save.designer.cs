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
	[Register ("Save")]
	partial class Save
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn2ndData { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnGet1stDatra { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSaveData { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		SaveData_UIViewController SaveDataViewController { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel txtSaveData { get; set; }

		[Action ("btn2ndData_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn2ndData_TouchUpInside (UIButton sender);

		[Action ("btnGet1stDatra_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnGet1stDatra_TouchUpInside (UIButton sender);

		[Action ("btnSaveData_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSaveData_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btn2ndData != null) {
				btn2ndData.Dispose ();
				btn2ndData = null;
			}
			if (btnGet1stDatra != null) {
				btnGet1stDatra.Dispose ();
				btnGet1stDatra = null;
			}
			if (btnSaveData != null) {
				btnSaveData.Dispose ();
				btnSaveData = null;
			}
			if (SaveDataViewController != null) {
				SaveDataViewController.Dispose ();
				SaveDataViewController = null;
			}
			if (txtSaveData != null) {
				txtSaveData.Dispose ();
				txtSaveData = null;
			}
		}
	}
}
