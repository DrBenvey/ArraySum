using ArraySumLibrary.ScalarAlgebra.Base;
using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;

namespace Tests.CorrectResult.ScalarAlgebra.TestsData
{
    public class WorkerCalendarCalculatorTestData
    {
        private static readonly WorkerCalendarCalculator workerCalendarCalculator = new WorkerCalendarCalculator();
        /// <summary>
        /// data for testing addition
        /// </summary>
        public static IEnumerable<object[]> AddTestDataCorrect =>
            new List<object[]>
            {
                new object[]
                {
                    workerCalendarCalculator.Add(
                        new WorkerCalendar(
                            "1",
                            new TimeSpan(1,1,1),
                            new TimeSpan(1, 1, 1),
                            11),
                        new WorkerCalendar(
                            "1",
                            new TimeSpan(1, 1, 1),
                            new TimeSpan(1, 1, 1),
                            22)),
                    new WorkerCalendar(
                            "Total",
                            new TimeSpan(2, 2, 2),
                            new TimeSpan(2, 2, 2),
                            33)
                }
            };
    }
}
