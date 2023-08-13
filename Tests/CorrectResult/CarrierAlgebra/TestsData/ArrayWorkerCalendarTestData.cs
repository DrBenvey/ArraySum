using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;

namespace Tests.CorrectResult.CarrierAlgebra.TestsData
{
    public class ArrayWorkerCalendarTestData
    {
        private static readonly ArrayElementsSum<WorkerCalendar> arrayElementsSum =
            new ArrayElementsSum<WorkerCalendar>(new WorkerCalendarCalculator());

        private static readonly Dictionary<WorkerCalendar, List<WorkerCalendar>> keyValuePairs =
            new Dictionary<WorkerCalendar, List<WorkerCalendar>>
            {
                {   
                    new WorkerCalendar(
                            "Total",
                            new TimeSpan(2, 2, 2),
                            new TimeSpan(2, 2, 2),
                            33), 
                    new List<WorkerCalendar>{
                            new WorkerCalendar(
                                "1",
                                new TimeSpan(1,1,1),
                                new TimeSpan(1, 1, 1),
                                11),
                            new WorkerCalendar(
                                "2",
                                new TimeSpan(1, 1, 1),
                                new TimeSpan(1, 1, 1),
                                22) }
                    },
                {
                    new WorkerCalendar(
                            "Total",
                            new TimeSpan(4, 4, 4),
                            new TimeSpan(3, 3, 3),
                            66),
                    new List<WorkerCalendar>{
                            new WorkerCalendar(
                                "1",
                                new TimeSpan(1,1,1),
                                new TimeSpan(1, 1, 1),
                                11),
                            new WorkerCalendar(
                                "2",
                                new TimeSpan(1, 1, 1),
                                new TimeSpan(1, 1, 1),
                                22),
                    new WorkerCalendar(
                                "3",
                                new TimeSpan(2, 2, 2),
                                new TimeSpan(1, 1, 1),
                                33)
                    }
                }
            };

        /// <summary>
        /// data for testing PlainSumArray
        /// </summary>
        public static IEnumerable<object[]> PlainSumArrayTestData =>

            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[
                        new WorkerCalendar(
                            "Total",
                            new TimeSpan(2, 2, 2),
                            new TimeSpan(2, 2, 2),
                            33)]),
                    new WorkerCalendar(
                        "Total",
                        new TimeSpan(2, 2, 2),
                        new TimeSpan(2, 2, 2),
                        33)
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[
                        new WorkerCalendar(
                            "Total",
                            new TimeSpan(4, 4, 4),
                            new TimeSpan(3, 3, 3),
                            66)]),
                    new WorkerCalendar(
                        "Total",
                        new TimeSpan(4, 4, 4),
                        new TimeSpan(3, 3, 3),
                        66)
                }
            };
        /// <summary>
        /// data for testing LinqSumArray
        /// </summary>
        public static IEnumerable<object[]> LinqSumArrayTestData =>
            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs[
                        new WorkerCalendar(
                            "Total",
                            new TimeSpan(2, 2, 2),
                            new TimeSpan(2, 2, 2),
                            33)]),
                    new WorkerCalendar(
                        "Total",
                        new TimeSpan(2, 2, 2),
                        new TimeSpan(2, 2, 2),
                        33)
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs[
                        new WorkerCalendar(
                            "Total",
                            new TimeSpan(4, 4, 4),
                            new TimeSpan(3, 3, 3),
                            66)]),
                    new WorkerCalendar(
                        "Total",
                        new TimeSpan(4, 4, 4),
                        new TimeSpan(3, 3, 3),
                        66)
                }
            };
        /// <summary>
        /// data for testing ParallerSum
        /// </summary>
        public static IEnumerable<object[]> ParallerSumTestData =>
            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.ParallerSum(keyValuePairs[
                        new WorkerCalendar(
                            "Total",
                            new TimeSpan(2, 2, 2),
                            new TimeSpan(2, 2, 2),
                            33)]),
                    new WorkerCalendar(
                        "Total",
                        new TimeSpan(2, 2, 2),
                        new TimeSpan(2, 2, 2),
                        33)
                },
                new object[]
                {
                    arrayElementsSum.ParallerSum(keyValuePairs[
                        new WorkerCalendar(
                            "Total",
                            new TimeSpan(4, 4, 4),
                            new TimeSpan(3, 3, 3),
                            66)]),
                    new WorkerCalendar(
                        "Total",
                        new TimeSpan(4, 4, 4),
                        new TimeSpan(3, 3, 3),
                        66)
                }
            };
    }
}
