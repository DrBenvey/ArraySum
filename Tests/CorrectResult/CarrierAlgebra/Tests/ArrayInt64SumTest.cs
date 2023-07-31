using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;
using Tests.CorrectResult.CarrierAlgebra.TestsData;

namespace Tests.CorrectResult.CarrierAlgebra.Tests
{
    public class ArrayInt64SumTest
    {
        /// <summary>
        /// Global General Equality Test
        /// </summary>
        [Fact]
        public void GlobalArrayElementsSumTest()
        {
            int length = 123;
            var arrayElementsSum = new ArrayElementsSum<long>(
                new Int64Calculator());
            string res1 = string.Empty;
            string res2 = string.Empty;
            Random rnd = new Random();

            long[] a = new long[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17);
            try
            {
                res1 = arrayElementsSum.PlainSumArray(a)
                        .ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            try
            {
                res2 = arrayElementsSum.LinqSumArray(a)
                        .ToString();
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
        [MemberData(nameof(ArrayInt64SumTestData.PlainSumArrayTestData), MemberType = typeof(ArrayInt64SumTestData))]
        public void PlainSumArrayTestCorrect(long InCode, long InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing linq addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayInt64SumTestData.LinqSumArrayTestData), MemberType = typeof(ArrayInt64SumTestData))]
        public void LinqSumArrayTestCorrect(long InCode, long InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing Sequential Addition with overflow
        /// </summary>
        [Fact]
        public void PlainSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<long>(new Int64Calculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.PlainSumArray(new long[2] { -11, long.MinValue })
                        .ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Arithmetic operation resulted in an overflow.");
        }
        /// <summary>
        /// Testing Linq Addition with overflow
        /// </summary>
        [Fact]
        public void LinqSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<long>(new Int64Calculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.LinqSumArray(new long[2] { -11, long.MinValue })
                        .ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Arithmetic operation resulted in an overflow.");
        }
    }
}
