using System.ComponentModel.Composition;

namespace Ultima
{
	/// <summary>
	/// Simple helper class that allows to import a service using MEF API.
	/// </summary>
	public class ImportHelper<T>
	{
		[Import]
		public T Imported { get; set; }
	}
}
