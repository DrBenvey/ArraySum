using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using Tests.BenchmarkResult.CarrierAlgebra.BenchmarksData;
using Xunit.Abstractions;

namespace Tests.BenchmarkResult.CarrierAlgebra.Benchmarks
{
    [Trait("Category", "Unit")]
    public class ArrayWorkerCalendarBenchmark
    {
        private readonly ITestOutputHelper _output;

        public ArrayWorkerCalendarBenchmark(ITestOutputHelper output)
        {
            _output = output;
        }
        /// <summary>
        /// PlainSum for String
        /// </summary>
        [Fact]
        public void TestPerformance_PlainSum_ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
            .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ArrayWorkerCalendarBenchmarkDataPlainSumArray>(config);

            _output.WriteLine(logger.GetLog());
        }
        /// <summary>
        /// LinqSumArray for String
        /// </summary>
        [Fact]
        public void TestPerformance_LinqSumArray_ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ArrayWorkerCalendarBenchmarkDataLinqSumArray>(config);

            _output.WriteLine(logger.GetLog());
        }
        /// <summary>
        /// ParallerSum for String
        /// </summary>
        [Fact]
        public void TestPerformance_ParallerSum_ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ArrayWorkerCalendarBenchmarkDataParallerSum>(config);

            _output.WriteLine(logger.GetLog());
        }
    }
}
