using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using Tests.BenchmarkResult.CarrierAlgebra.BenchmarksData;
using Xunit.Abstractions;

namespace Tests.BenchmarkResult.CarrierAlgebra.Benchmarks
{
    [Trait("Category", "Unit")]
    public class ArrayInt64SumBenchmark
    {
        private readonly ITestOutputHelper _output;

        public ArrayInt64SumBenchmark(ITestOutputHelper output)
        {
            _output = output;
        }
        /// <summary>
        /// PlainSum for Int64
        /// </summary>
        [Fact]
        public void TestPerformance_PlainSum_ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ArrayInt64SumBenchmarkDataPlainSumArray>(config);

            _output.WriteLine(logger.GetLog());
        }
        /// <summary>
        /// LinqSumArray for Int64
        /// </summary>
        [Fact]
        public void TestPerformance_LinqSumArray_ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ArrayInt64SumBenchmarkDataLinqSumArray>(config);

            _output.WriteLine(logger.GetLog());
        }
        /// <summary>
        /// ParallerSum for Int64
        /// </summary>
        [Fact]
        public void TestPerformance_ParallerSum_ShouldAllocateNothing()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<ArrayInt64SumBenchmarkDataLinqSumArray>(config);

            _output.WriteLine(logger.GetLog());
        }
    }
}
