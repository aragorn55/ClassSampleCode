using System;
using DeathClock.PCL;

using Android.OS;
using Java.Interop;

namespace DeathClock2.OB.Droid
{
	public class CPersonPassable  : Java.Lang.Object, IParcelable
	{
		private cPerson _User = new cPerson ();

		public cPerson User {
			get {
				return _User;
			}
			set {
				_User = value;
			}
		}

		public CPersonPassable ()
		{
			
		}

		public CPersonPassable (double d, double d2, double d3, double d4, string str, string str2)
		{
			_User.Height = d;
			_User.Weight = d;
			_User.CigPerDay = d;
			_User.HrsSleep = d;
			_User.SetGender (str);
			_User.SetBirthDay (str2);

		}

		#region IParcelable implementation

		public int DescribeContents ()
		{
			return 0;
		}

		public void WriteToParcel (Parcel dest, ParcelableWriteFlags flags)
		{
			dest.WriteDouble (_User.Height);
			dest.WriteDouble (_User.Weight);
			dest.WriteDouble (_User.CigPerDay);
			dest.WriteDouble (_User.HrsSleep);
			dest.WriteString (_User.Sex.ToString ());
			dest.WriteString (_User.BirthDate.ToString ());
		}

		[ExportField ("CREATOR")]
		public static CPersonParcelableCreator InititalizeCreator ()
		{
			return new CPersonParcelableCreator ();
		}



		#endregion

	



	}
}

