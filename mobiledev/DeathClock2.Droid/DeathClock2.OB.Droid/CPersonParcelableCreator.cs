using System;
using Android.OS;

namespace DeathClock2.OB.Droid
{
	public class CPersonParcelableCreator: Java.Lang.Object, IParcelableCreator
	{
		public Java.Lang.Object CreateFromParcel (Parcel source)
		{
			return new CPersonPassable (source.ReadDouble (), source.ReadDouble (), source.ReadDouble (), source.ReadDouble (), source.ReadString (), source.ReadString ());
		}

		public Java.Lang.Object[] NewArray (int size)
		{
			return new Java.Lang.Object[size];
		}

		public CPersonParcelableCreator ()
		{
		}
	}
}

