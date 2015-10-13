using System;

namespace TemperatureConverter.BL
{
	public static class CTempConvert
	{
		public static double ToCelsius(double input)
		{
			return (input - 32) * 5.0 / 9.0;
		}

		public static double ToFahrenheit(double input)
		{
			return input * 9.0 / 5.0 + 32;
		}

	}
}

