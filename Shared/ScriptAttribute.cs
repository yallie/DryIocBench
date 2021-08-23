using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ultima
{
	/// <summary>
	/// Marks a class or an interface as a script with the given identity.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = false), MetadataAttribute]
	public class ScriptAttribute : Attribute, IScriptMetadata
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ScriptAttribute"/> class.
		/// </summary>
		/// <param name="id">Script identity.</param>
		public ScriptAttribute(long id)
		{
			ScriptID = id;
		}

		/// <summary>
		/// Gets script identity.
		/// </summary>
		public long ScriptID { get; private set; }

		/// <summary>
		/// Returns all types decorated with <see cref="ScriptAttribute"/> from the given assembly.
		/// </summary>
		/// <param name="asm"><see cref="Assembly"/> to inspect.</param>
		/// <returns>A sequence of types.</returns>
		public static IEnumerable<Type> GetScriptTypes(Assembly asm)
		{
			return
				from t in asm.GetTypes()
				where t.IsInterface && t.IsDefined(typeof(ScriptAttribute), false)
				select t;
		}

		/// <summary>
		/// Returns script identity for the given type.
		/// </summary>
		/// <param name="type"><see cref="Type"/> to inspect.</param>
		/// <returns>Script identity.</returns>
		public static long GetScriptIdentity(Type type)
		{
			var attr = type.GetCustomAttribute<ScriptAttribute>(false);
			if (attr == null)
			{
				throw new InvalidOperationException("Type " + type + " is not decorated with ScriptAttribute.");
			}

			return attr.ScriptID;
		}
	}
}
