using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;
using BenchmarkDotNet.Attributes;

namespace Tests.BenchmarkResult.CarrierAlgebra.BenchmarksData
{
    [MemoryDiagnoser]
    public class ArrayStringSumBenchmarkDataPlainSumArray
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            string[] a = new string[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17).ToString();
            var arrayElementsSum = new ArrayElementsSum<string>(
                new StringCalculator());
            arrayElementsSum.PlainSumArray(a);
        }
    }
    [MemoryDiagnoser]
    public class ArrayStringSumBenchmarkDataLinqSumArray
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            string[] a = new string[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17).ToString();
            var arrayElementsSum = new ArrayElementsSum<string>(
                new StringCalculator());
            arrayElementsSum.LinqSumArray(a);
        }
    }
    [MemoryDiagnoser]
    public class ArrayStringSumBenchmarkDataParallerSum
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            string[] a = new string[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17).ToString();
            var arrayElementsSum = new ArrayElementsSum<string>(
                new StringCalculator());
            arrayElementsSum.ParallerSum(a);
        }
    }
}
