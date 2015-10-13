using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SaveData.UI
{
	partial class SaveViewController : UIViewController
	{
		public SaveViewController (IntPtr handle) : base (handle)
		{
		}

		partial void btnSaveData1_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			PickerDataViewModel pkrNames = new PickerDataViewModel ();

		}
	}
}
