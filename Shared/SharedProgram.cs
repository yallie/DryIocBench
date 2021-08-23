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

		public static void RunAllBenchmarks(Func<ContainerAdapter> containerFactory, Tracer trace)
		{
			ImportSingleBenchmark(containerFactory(), trace);
			ImportManyBenchmark(containerFactory(), trace);
			ImportManyWithMetadataBenchmark(containerFactory(), trace);
		}

		public static void ImportSingleBenchmark(ContainerAdapter container, Tracer trace)
		{
			// register builtin services and scripts
			container.RegisterExports(typeof(RootInterface).Assembly);

			trace("Started static benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<RootInterface>>();
				scope.InjectPropertiesAndFields(svc);
				trace("Imported service: {TypeName}", svc.Imported.Value.GetType().Name);
			}

			// run benchmark
			var benchmark = new Benchmark(container);
			var action = new Action(benchmark.ImportRootService);

			trace("Warming up...");
			for (var i = 0; i < 5; i++)
			{
				action();
			}

			//Console.ReadLine();

			trace("Running the benchmark...");
			var sw = Stopwatch.StartNew();
			for (var i = 0; i < 1000; i++)
			{
				action();
			}

			sw.Stop();
			trace("Time elapsed: {0}", sw.Elapsed);
		}

		public static void ImportManyBenchmark(ContainerAdapter container, Tracer trace)
		{
			// register builtin services and scripts
			container.RegisterExports(typeof(RootInterface).Assembly);

			trace("Started static benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<CommonInterface>[]>();
				scope.InjectPropertiesAndFields(svc);
				trace("Imported common services: {TypeName}", svc.Imported.Length);
			}

			// run benchmark
			var benchmark = new Benchmark(container);
			var action = new Action(benchmark.ImportMany);

			trace("Warming up...");
			for (var i = 0; i < 5; i++)
			{
				action();
			}

			//Console.ReadLine();

			trace("Running the benchmark...");
			var sw = Stopwatch.StartNew();
			for (var i = 0; i < 10000; i++)
			{
				action();
			}

			sw.Stop();
			trace("Time elapsed: {0}", sw.Elapsed);
		}

		public static void ImportManyWithMetadataBenchmark(ContainerAdapter container, Tracer trace)
		{
			// register builtin services and scripts
			container.RegisterExports(typeof(RootInterface).Assembly);

			trace("Started static benchmark.");

			// test if everything is ok
			using (var scope = container.OpenScope())
			{
				var svc = new ImportHelper<Lazy<CommonInterface, IScriptMetadata>[]>();
				scope.InjectPropertiesAndFields(svc);
				trace("Imported common services: {TypeName}", svc.Imported.Length);
				trace("Service metadata: {ScriptAttributes}", svc.Imported.Select(s => s.Metadata.ScriptID));
			}

			// run benchmark
			var benchmark = new Benchmark(container);
			var action = new Action(benchmark.ImportManyWithMetadata);

			trace("Warming up...");
			for (var i = 0; i < 5; i++)
			{
				action();
			}

			//Console.ReadLine();

			trace("Running the benchmark...");
			var sw = Stopwatch.StartNew();
			for (var i = 0; i < 10000; i++)
			{
				action();
			}

			sw.Stop();
			trace("Time elapsed: {0}", sw.Elapsed);
		}
	}
}
