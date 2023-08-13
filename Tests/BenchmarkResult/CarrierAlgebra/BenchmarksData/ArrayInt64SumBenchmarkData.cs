using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;
using BenchmarkDotNet.Attributes;

namespace Tests.BenchmarkResult.CarrierAlgebra.BenchmarksData
{
    [MemoryDiagnoser]
    public class ArrayInt64SumBenchmarkDataPlainSumArray
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            long[] a = new long[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17);
            var arrayElementsSum = new ArrayElementsSum<long>(
                new Int64Calculator());
            arrayElementsSum.PlainSumArray(a);
        }
    }
    [MemoryDiagnoser]
    public class ArrayInt64SumBenchmarkDataLinqSumArray
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            long[] a = new long[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17);
            var arrayElementsSum = new ArrayElementsSum<long>(
                new Int64Calculator());
            arrayElementsSum.LinqSumArray(a);
        }
    }
    [MemoryDiagnoser]
    public class ArrayInt64SumBenchmarkDataParallerSum
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            long[] a = new long[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17);
            var arrayElementsSum = new ArrayElementsSum<long>(
                new Int64Calculator());
            arrayElementsSum.ParallerSum(a);
        }
    }
}
