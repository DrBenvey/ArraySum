using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;
using Tests.CorrectResult.ScalarAlgebra.TestsData;

namespace Tests.CorrectResult.ScalarAlgebra.Tests
{
    public class WorkerCalendarCalculatorTest
    {
        /// <summary>
        /// Testing getting zero
        /// </summary>
        [Fact]
        public void ZeroTest()
        {
            Assert.True(
                new WorkerCalendarCalculator().Zero.Equals(
                    new WorkerCalendar(
                    "Total",
                    TimeSpan.Zero,
                    TimeSpan.Zero,
                    0))
                );
        }

        /// <summary>
        /// Testing adding with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(WorkerCalendarCalculatorTestData.AddTestDataCorrect), MemberType = typeof(WorkerCalendarCalculatorTestData))]
        public void AddTestCorrect(WorkerCalendar InCode, WorkerCalendar InReal)
        {
            Assert.Equal(InReal, InCode);
        }

        /// <summary>
        /// Testing adding with overflow
        /// </summary>
        [Fact]
        public void AddTestException()
        {
            WorkerCalendarCalculator workerCalendarCalculator = new WorkerCalendarCalculator();
            string res1 = string.Empty;
            string res2 = string.Empty;
            string res3 = string.Empty;
            try
            {
                res1 = workerCalendarCalculator.
                    Add(
                        new WorkerCalendar(
                            "1",
                            new TimeSpan(1,1,1),
                            new TimeSpan(1, 1, 1),
                            11),
                        new WorkerCalendar(
                            "1",
                            new TimeSpan(1, 1, 1),
                            new TimeSpan(1, 1, 1),
                            Int64.MaxValue)
                    ).ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            try
            {
                res2 = workerCalendarCalculator.
                    Add(
                        null,
                        new WorkerCalendar(
                            "1",
                            new TimeSpan(1, 1, 1),
                            new TimeSpan(1, 1, 1),
                            Int64.MaxValue)
                    ).ToString();
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            try
            {
                res3 = workerCalendarCalculator.
                    Add(
                        new WorkerCalendar(
                            "1",
                            new TimeSpan(1, 1, 1),
                            new TimeSpan(1, 1, 1),
                            11),
                        null
                    ).ToString();
            }
            catch (Exception ex)
            {
                res3 = ex.Message;
            }
            Assert.True(
                        res1 == "Arithmetic operation resulted in an overflow." &&
                        res2 == "Value cannot be null. (Parameter 'a')" &&
                        res3 == "Value cannot be null. (Parameter 'b')");
        }
    }
}
