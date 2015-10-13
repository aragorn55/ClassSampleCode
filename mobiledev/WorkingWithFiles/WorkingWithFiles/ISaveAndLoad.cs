using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
	public interface ISaveAndLoad
	{
		Task SaveTextAsync(string filename, string text);
		Task<string> LoadTextAsync();
	}
}

