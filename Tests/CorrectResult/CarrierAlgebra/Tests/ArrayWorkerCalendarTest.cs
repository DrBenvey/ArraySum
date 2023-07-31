using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;
using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;
using Tests.CorrectResult.CarrierAlgebra.TestsData;

namespace Tests.CorrectResult.CarrierAlgebra.Tests
{
    public class ArrayWorkerCalendarTest
    {
        /// <summary>
        /// Global General Equality Test
        /// </summary>
        [Fact]
        public void GlobalArrayElementsSumTest()
        {
            int length = 123;
            var arrayElementsSum = new ArrayElementsSum<WorkerCalendar>(
                new WorkerCalendarCalculator());
            string res1 = string.Empty;
            string res2 = string.Empty;
            Random rnd = new Random();

            WorkerCalendar[] a = new WorkerCalendar[length];
            for (int i = 0; i < length; i++)
                a[i] = new WorkerCalendar(
                    "some name",
                    TimeSpan.FromSeconds(rnd.Next(100, 500)),
                    TimeSpan.FromSeconds(rnd.Next(100, 500)),
                    rnd.Next(10, 50));
            try
            {
                res1 = arrayElementsSum.PlainSumArray(a).ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            try
            {
                res2 = arrayElementsSum.LinqSumArray(a).ToString();
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            Assert.True(res1 == res2);
        }
        /// <summary>
        /// Testing Sequential Addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayWorkerCalendarTestData.PlainSumArrayTestData), MemberType = typeof(ArrayWorkerCalendarTestData))]
        public void PlainSumArrayTestCorrect(WorkerCalendar InCode, WorkerCalendar InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing linq addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayWorkerCalendarTestData.LinqSumArrayTestData), MemberType = typeof(ArrayWorkerCalendarTestData))]
        public void LinqSumArrayTestCorrect(WorkerCalendar InCode, WorkerCalendar InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing Sequential Addition with overflow
        /// </summary>
        [Fact]
        public void PlainSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<WorkerCalendar>(new WorkerCalendarCalculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.PlainSumArray(new WorkerCalendar[2] 
                { 
                    null,
                    new WorkerCalendar(
                        "1",
                        new TimeSpan(1,1,1),
                        new TimeSpan(1, 1, 1),
                        11)
                }).ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Value cannot be null. (Parameter 'b')");
        }
        /// <summary>
        /// Testing Linq Addition with overflow
        /// </summary>
        [Fact]
        public void LinqSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<WorkerCalendar>(new WorkerCalendarCalculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.LinqSumArray(new WorkerCalendar[2] 
                {
                    new WorkerCalendar(
                        "1",
                        new TimeSpan(1,1,1),
                        new TimeSpan(1, 1, 1),
                        11), 
                    null 
                }).ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Value cannot be null. (Parameter 'b')");
        }
    }
}
