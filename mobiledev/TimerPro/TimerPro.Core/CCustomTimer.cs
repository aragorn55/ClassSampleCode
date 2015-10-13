using System;

namespace TimerPro.Core
{
	public class CCustomerTimer
	{
		private int _intSec;
		private int _intMin;
		private int _intHours;
		public CCustomerTimer ()
		{
			_intSec = 0;
			_intMin = 0;
			_intHours = 0;
		}
		public void Reset()
		{
			_intSec = 0;
			_intMin = 0;
			_intHours = 0;
		}
		public string GetCurrentTickCount()
		{
			return _intHours.ToString ().PadLeft (2, '0') +":" +  _intMin.ToString ().PadLeft (2, '0') + ":" + _intSec.ToString ().PadLeft (2, '0');
		}
		public void SetTickElapsed()
		{
			_intSec++;
			if (_intSec == 60) {
				_intSec = 0;
				_intMin++;
				if (_intMin == 60) {
					_intMin = 0;
					_intHours++;
				}
			}
		}

	}
}

