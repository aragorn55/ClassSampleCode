using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace SaveData.UI
{
	partial class PickerDataViewModel : UIPickerViewModel
	{
		List<string> oData = new List<string> ();

		public List<string> OData {
			get {
				return oData;
			}
			set {
				oData = value;
			}
		}

		public PickerDataViewModel (IntPtr handle) : base (handle)
		{
			oData.Add ("Homer");
			oData.Add ("Bart");
			oData.Add ("Marge");
			oData.Add ("Lisa");
			oData.Add ("Maggie");

		}

		public override nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}

		public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return oData.Count;
		}
	}
}
