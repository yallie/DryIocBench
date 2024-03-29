﻿using System;
using System.Reflection;
using DryIoc;
using DryIoc.MefAttributedModel;

namespace Ultima
{
	public class ContainerAdapter : IMyContainer, IMyResolverContext
	{
		public ContainerAdapter(IContainer dryIoc) => Container = dryIoc;

		private IContainer Container { get; set; }

		public void Dispose() => Container.Dispose();

		public T Resolve<T>() => Container.Resolve<T>();

		public void InjectPropertiesAndFields(object instance) =>
			Container.InjectPropertiesAndFields(instance);

		public IMyResolverContext OpenScope() =>
			new ContainerAdapter(Container.OpenScope());

		public void RegisterExports(params Assembly[] assemblies)
		{
			if (Container is IContainer container)
			{
				container.RegisterExports(assemblies);
				return;
			}

			throw new InvalidOperationException();
		}
	}
}
