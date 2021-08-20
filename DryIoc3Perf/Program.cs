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
				.WriteTo.File("DryIoc3Perf.log")
				.CreateLogger();

			logger.Information("Starting up...");

			// DryIoc container factory
			Func<IContainer> dryFactory = () => new Container().WithMef()
				.With(rules => rules
				.With(FactoryMethod.ConstructorWithResolvableArguments)
				.WithCaptureContainerDisposeStackTrace()
				.WithoutThrowIfDependencyHasShorterReuseLifespan()
				.WithDefaultReuse(Reuse.ScopedOrSingleton));

			// run benchmarks
			SharedProgram.StaticBenchmark(new ContainerAdapter(dryFactory()), logger.Information);
			SharedProgram.LazyBenchmark(new ContainerAdapter(dryFactory()), logger.Information);
		}
	}
}
