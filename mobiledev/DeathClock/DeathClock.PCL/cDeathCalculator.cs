using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeathClock.PCL
{
	public class cDeathCalculator
	{
		cPerson oUser;
		private double _YearsLeft;
		//cPerson _User;


		//private int _YearsLeft;
        

		public double FindTimeLeft (cPerson voUser)
		{
			oUser = voUser;
			_YearsLeft = FindYearsLeft (FindBaseYears ()) + FindBMIYrs ();
			
			return _YearsLeft;
		}

		private double FindYearsLeft (double vBaseYears)
		{
			return vBaseYears - oUser.ComputeAge ();
		}

		private double FindBaseYears ()
		{
			if (oUser.Sex == eGender.male) {
				return 85.0;
			} else {
				return 90.0;
			}
		}

		private double FindBMIYrs ()
		{
			double _BMI = (oUser.Weight / (oUser.Height * oUser.Height)) * 703.0;
            
			if (_BMI < 16.0) {
				return -3.0;
			} else if (_BMI < 28.0) {
				return 1.0;
			}
			if (_BMI < 35.0) {
				return -5.0;
			} else {
				return -8.0;
			}
		}

		public cDeathCalculator ()
		{
//			oUser = new cPerson ();
//			oUser.Height = 71;
//			oUser.Weight = 140;
//			oUser.SetBirthDay ("12/15/1985");
//			oUser.SetGender ("male");
//			oUser.CigPerDay = 0;
//			oUser.HrsSleep = 8;
		}

        
        
       

	}
}
