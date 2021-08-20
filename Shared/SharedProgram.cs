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

		public static void StaticBenchmark(ContainerAdapter container, Tracer trace)
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
	}
}
