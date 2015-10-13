using System;
using System.Text;

namespace PhoneWord.UI
{
	public static class PhonewordTranslator
	{
		public static string ToNumber(string sInput)
		{
			if (string.IsNullOrWhiteSpace (sInput)) {
				return "";
			} else {
				sInput = sInput.ToUpperInvariant ();
			
				var newNumber = new StringBuilder ();
			// Loop through the input string
				foreach (var c in sInput) 
				{
					if ("0123456789".Contains (c))
						newNumber.Append (c);
					else {
						var result = TranslateToNumber (c);
						if (result != null)
							newNumber.Append (result);
					}

				}
			
				return newNumber.ToString ();
			
			}

		}
		static bool Contains(this string keyString, char c)
		{
			return keyString.IndexOf (c) >= 0;

		}
		static int? TranslateToNumber(char c)
		{
			if ("ABC".Contains (c)) {
				return 2;
			} 
			else if ("DEF".Contains (c)) {
				return 3;
			} 
			else if ("GHI".Contains (c)) {
				return 4;
			}
			else if ("JKL".Contains (c)) {
				return 5;
			}	
			else if ("MNO".Contains (c)) {
				return 6;
			}
			else if ("PQR".Contains (c)) {
				return 7;
			}
			else if ("STU".Contains (c)) {
				return 8;
			}
			else if ("VWX".Contains (c)) {
				return 9;
			}
			else if ("YZ".Contains (c)) {
				return 0;
			}
			else
			{
				return -1;

			}
		}
	}
}

