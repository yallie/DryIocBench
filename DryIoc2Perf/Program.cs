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
				.WriteTo.File("DryIoc2Perf.log")
				.CreateLogger();

			logger.Information("Starting up...");

			// DryIoc container factory
			Func<IContainer> dryFactory = () => new Container().WithMef()
				.With(rules => rules
				.With(FactoryMethod.ConstructorWithResolvableArguments)
				.WithCaptureContainerDisposeStackTrace()
				.WithoutThrowIfDependencyHasShorterReuseLifespan()
				.WithDefaultReuseInsteadOfTransient(Reuse.ScopedOrSingleton));

			// run benchmarks
			SharedProgram.RunAllBenchmarks(() => new ContainerAdapter(dryFactory()), logger.Information);
		}
	}
}
