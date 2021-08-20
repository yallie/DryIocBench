using System;

namespace Ultima
{
	public interface IMyResolverContext : IDisposable
	{
		void InjectPropertiesAndFields(object instance);
	}
}
