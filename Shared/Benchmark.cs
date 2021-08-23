using System;
using System.Diagnostics;

namespace Ultima
{
	/// <summary>
	/// Imports a web service, runs its method and checks if it's not null.
	/// </summary>
	public class Benchmark
	{
		public Benchmark(IMyContainer container) => Container = container;

		private IMyContainer Container { get; set; }

		public void ImportSingle()
		{
			using (var scope = Container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<RootInterface>>();
				scope.InjectPropertiesAndFields(svc);
				Debug.Assert(svc.Imported != null);
				Debug.Assert(svc.Imported.Value != null);
			}
		}

		public void ImportMany()
		{
			using (var scope = Container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<CommonInterface>[]>();
				scope.InjectPropertiesAndFields(svc);
				Debug.Assert(svc.Imported != null);
				Debug.Assert(svc.Imported.Length > 0);
			}
		}

		public void ImportManyWithMetadata()
		{
			using (var scope = Container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<CommonInterface, IScriptMetadata>[]>();
				scope.InjectPropertiesAndFields(svc);
				Debug.Assert(svc.Imported != null);
				Debug.Assert(svc.Imported.Length > 0);
			}
		}

		public void ResolveSingle()
		{
			using (var scope = Container.OpenScope())
			{
				var resolved = scope.Resolve<Lazy<RootInterface>>();
				scope.InjectPropertiesAndFields(resolved);
				Debug.Assert(resolved != null);
				Debug.Assert(resolved.Value != null);
			}
		}

		public void ResolveMany()
		{
			using (var scope = Container.OpenScope())
			{
				var resolved = scope.Resolve<Lazy<CommonInterface>[]>();
				Debug.Assert(resolved != null);
				Debug.Assert(resolved.Length > 0);
			}
		}

		public void ResolveManyWithMetadata()
		{
			using (var scope = Container.OpenScope())
			{
				var resolved = scope.Resolve<Lazy<CommonInterface, IScriptMetadata>[]>();
				Debug.Assert(resolved != null);
				Debug.Assert(resolved.Length > 0);
			}
		}
	}
}
