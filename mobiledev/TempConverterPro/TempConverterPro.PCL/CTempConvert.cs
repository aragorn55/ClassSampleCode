using System;

namespace TempConverterPro.PCL
{
	public static class CTempConvert
	{
		public static double ConvertToCelsius(double vdblTemp)
		{
			double temp = ((vdblTemp * 9) / 5) + 32; 
			return temp;
		}
		public static double ConvertToFahrenheit(double vdblTemp)
		{
			double temp = ((vdblTemp - 32 ) * 5) / 9; 
			return temp;
		}
	}
}

