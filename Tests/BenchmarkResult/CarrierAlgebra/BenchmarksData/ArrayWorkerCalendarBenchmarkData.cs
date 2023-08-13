using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;
using BenchmarkDotNet.Attributes;

namespace Tests.BenchmarkResult.CarrierAlgebra.BenchmarksData
{
    [MemoryDiagnoser]
    public class ArrayWorkerCalendarBenchmarkDataPlainSumArray
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            WorkerCalendar[] a = new WorkerCalendar[length];
            for (int i = 0; i < length; i++)
                a[i] = new WorkerCalendar(
                    "some name",
                    TimeSpan.FromSeconds(rnd.Next(1, 5)),
                    TimeSpan.FromSeconds(rnd.Next(1, 5)),
                    rnd.Next(1, 2));
            var arrayElementsSum = new ArrayElementsSum<WorkerCalendar>(
                new WorkerCalendarCalculator());
            arrayElementsSum.PlainSumArray(a);
        }
    }
    [MemoryDiagnoser]
    public class ArrayWorkerCalendarBenchmarkDataLinqSumArray
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            WorkerCalendar[] a = new WorkerCalendar[length];
            for (int i = 0; i < length; i++)
                a[i] = new WorkerCalendar(
                    "some name",
                    TimeSpan.FromSeconds(rnd.Next(1, 5)),
                    TimeSpan.FromSeconds(rnd.Next(1, 5)),
                    rnd.Next(1, 2));
            var arrayElementsSum = new ArrayElementsSum<WorkerCalendar>(
                new WorkerCalendarCalculator());
            arrayElementsSum.LinqSumArray(a);
        }
    }
    [MemoryDiagnoser]
    public class ArrayWorkerCalendarBenchmarkDataParallerSum
    {
        [Benchmark]
        public void ProcessRequest()
        {
            Random rnd = new Random();
            int length = 1408;
            WorkerCalendar[] a = new WorkerCalendar[length];
            for (int i = 0; i < length; i++)
                a[i] = new WorkerCalendar(
                    "some name",
                    TimeSpan.FromSeconds(rnd.Next(1, 5)),
                    TimeSpan.FromSeconds(rnd.Next(1, 5)),
                    rnd.Next(1, 2));
            var arrayElementsSum = new ArrayElementsSum<WorkerCalendar>(
                new WorkerCalendarCalculator());
            arrayElementsSum.ParallerSum(a);
        }
    }
}
