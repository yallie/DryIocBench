using System;

namespace Ultima
{
	public interface IMyResolverContext : IDisposable
	{
		T Resolve<T>();

		void InjectPropertiesAndFields(object instance);
	}
}
