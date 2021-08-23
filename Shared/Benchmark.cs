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

		public void ImportRootService()
		{
			using (var scope = Container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<RootInterface>>();
				scope.InjectPropertiesAndFields(svc);
				Debug.Assert(svc.Imported != null);
				Debug.Assert(svc.Imported.Value != null);
			}
		}

		public void ImportRootLazyService()
		{
			using (var scope = Container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<RootLazyInterface>>();
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
	}
}
