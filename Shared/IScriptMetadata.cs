using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultima
{
	/// <summary>
	/// Interface for script metadata.
	/// </summary>
	public interface IScriptMetadata
	{
		/// <summary>
		/// Gets script identity.
		/// </summary>
		long ScriptID { get; }
	}
}
