using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Utilities.OB;
namespace DeathClock.PCL
{
	public class cPerson
	{
        
		private DateTime _BirthDate;
		private double _CigPerDay;
		private double _Height;
		private double _HrsSleep;

		private eGender _Sex;

		private double _Weight;

       
		public DateTime BirthDate {
			get { return _BirthDate; }
			set { _BirthDate = value; }
		}



		public double CigPerDay {
			get { return _CigPerDay; }
			set { _CigPerDay = value; }
		}



		public double Height {
			get { return _Height; }
			set { _Height = value; }
		}


		public void SetGender (string sGender)
		{
			if (sGender == "male") {
				Sex = eGender.male;
			} else if (sGender == "female") {
				Sex = eGender.female;
			}
				
		}

		public void SetBirthDay (string sBDay)
		{
			DateTime oDate = DateTime.Parse (sBDay);

			BirthDate = oDate;
		}

		public double HrsSleep {
			get { return _HrsSleep; }
			set { _HrsSleep = value; }
		}

	
		public eGender Sex {
			get { return _Sex; }
			set { _Sex = value; }
		}

		public double Weight {
			get { return _Weight; }
			set { _Weight = value; }
		}

		public cPerson ()
		{



			_CigPerDay = -1;
			_Height = -1;
			_HrsSleep = -1;

			//_Sex = eGender;
			_Weight = -1;


		}

		public double ComputeAge ()
		{
			DateTime newDate = DateTime.Now;

			// Difference in days, hours, and minutes.
			TimeSpan ts = newDate - _BirthDate;
			// Difference in days.
			//int differenceInDays = ts.;
			//  int differenceInDays = newDate.Subtract(mdBirthDate).TotalDays;
			//Console.WriteLine("Difference in days: {0} ", differenceInDays);
			DateTime now = DateTime.Today;
			int age = now.Year - _BirthDate.Year;
			if (_BirthDate > now.AddYears (-age))
				age--;
			return age;
		}
	}
}
