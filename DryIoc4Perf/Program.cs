using System;
using DryIoc;
using DryIoc.MefAttributedModel;
using Serilog;

namespace Ultima
{
	public class Program
	{
		static void Main()
		{
			// initialize default Serilog logger
			var logger = Log.Logger = new LoggerConfiguration()
				.WriteTo.Console()
				.WriteTo.File("DryIoc4Perf.log")
				.CreateLogger();

			logger.Information("Starting up...");

			// DryIoc container factory
			var dryIoc = new Container().WithMef()
				.With(rules => rules
				.With(FactoryMethod.ConstructorWithResolvableArguments)
				.WithCaptureContainerDisposeStackTrace()
				.WithoutThrowIfDependencyHasShorterReuseLifespan()
				.WithDefaultReuse(Reuse.ScopedOrSingleton));

			// run benchmarks
			SharedProgram.RunAllBenchmarks(new ContainerAdapter(dryIoc), logger.Information);
		}
	}
}
