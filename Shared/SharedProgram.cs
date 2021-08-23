using System;
using System.Linq;
using System.Diagnostics;

namespace Ultima
{
	/// <summary>
	/// Shared code for the Program.
	/// </summary>
	public static class SharedProgram
	{
		public delegate void Tracer(string format, params object[] arguments);

		public static void RunAllBenchmarks(ContainerAdapter container, Tracer trace)
		{
			// register builtin services and scripts
			container.RegisterExports(typeof(RootInterface).Assembly);

			ResolveSingleBenchmark(container, trace);
			ResolveManyBenchmark(container, trace);
			ResolveManyWithMetadataBenchmark(container, trace);

			ImportSingleBenchmark(container, trace);
			ImportManyBenchmark(container, trace);
			ImportManyWithMetadataBenchmark(container, trace);
		}

		public static void RunBenchmark(Action action, int count, Tracer trace)
		{
			trace("Warming up...");
			for (var i = 0; i < 5; i++)
			{
				action();
			}

			trace("Running the benchmark...");
			var sw = Stopwatch.StartNew();
			for (var i = 0; i < count; i++)
			{
				action();
			}

			sw.Stop();
			trace("Time elapsed: {0}", sw.Elapsed);
		}

		public static void ResolveSingleBenchmark(ContainerAdapter container, Tracer trace)
		{
			trace("Started ResolveSingle benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var resolved = scope.Resolve<Lazy<RootInterface>>();
				trace("Imported service: {TypeName}", resolved.Value.GetType().Name);
			}

			// run benchmark
			RunBenchmark(new Benchmark(container).ResolveSingle, 1000, trace);
		}

		public static void ResolveManyBenchmark(ContainerAdapter container, Tracer trace)
		{
			trace("Started ResolveMany benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var resolved = scope.Resolve<Lazy<CommonInterface>[]>();
				trace("Imported common services: {TypeName}", resolved.Length);
			}

			// run benchmark
			RunBenchmark(new Benchmark(container).ResolveMany, 10000, trace);
		}

		public static void ResolveManyWithMetadataBenchmark(ContainerAdapter container, Tracer trace)
		{
			trace("Started ResolveMany with metadata benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var resolved = scope.Resolve<Lazy<CommonInterface, IScriptMetadata>[]>();
				trace("Imported common services: {TypeName}", resolved.Length);
				trace("Service metadata: {ScriptAttributes}", resolved.Select(s => s.Metadata.ScriptID));
			}

			// run benchmark
			RunBenchmark(new Benchmark(container).ResolveManyWithMetadata, 10000, trace);
		}

		public static void ImportSingleBenchmark(ContainerAdapter container, Tracer trace)
		{
			trace("Started ImportSingle benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<RootInterface>>();
				scope.InjectPropertiesAndFields(svc);
				trace("Imported service: {TypeName}", svc.Imported.Value.GetType().Name);
			}

			// run benchmark
			RunBenchmark(new Benchmark(container).ImportSingle, 1000, trace);
		}

		public static void ImportManyBenchmark(ContainerAdapter container, Tracer trace)
		{
			trace("Started ImportMany benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<CommonInterface>[]>();
				scope.InjectPropertiesAndFields(svc);
				trace("Imported common services: {TypeName}", svc.Imported.Length);
			}

			// run benchmark
			RunBenchmark(new Benchmark(container).ImportMany, 10000, trace);
		}

		public static void ImportManyWithMetadataBenchmark(ContainerAdapter container, Tracer trace)
		{
			trace("Started ImportMany with metadata benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<CommonInterface, IScriptMetadata>[]>();
				scope.InjectPropertiesAndFields(svc);
				trace("Imported common services: {TypeName}", svc.Imported.Length);
				trace("Service metadata: {ScriptAttributes}", svc.Imported.Select(s => s.Metadata.ScriptID));
			}

			// run benchmark
			RunBenchmark(new Benchmark(container).ImportManyWithMetadata, 10000, trace);
		}
	}
}
