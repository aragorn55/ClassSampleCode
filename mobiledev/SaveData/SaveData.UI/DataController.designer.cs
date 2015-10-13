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
	[Register ("DataController")]
	partial class DataController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSaveData2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		DataController DataController { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker DatePicker1 { get; set; }

		[Action ("btnSaveData2_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSaveData2_TouchUpInside (UIButton sender);

		[Action ("DatePicker1_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void DatePicker1_ValueChanged (UIDatePicker sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSaveData2 != null) {
				btnSaveData2.Dispose ();
				btnSaveData2 = null;
			}
			if (DataController != null) {
				DataController.Dispose ();
				DataController = null;
			}
			if (DatePicker1 != null) {
				DatePicker1.Dispose ();
				DatePicker1 = null;
			}
		}
	}
}
