using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;
using Tests.CorrectResult.CarrierAlgebra.TestsData;

namespace Tests.CorrectResult.CarrierAlgebra.Tests
{
    public class ArrayStringSumTest
    {
        /// <summary>
        /// Global General Equality Test
        /// </summary>
        [Fact]
        public void GlobalArrayElementsSumTest()
        {
            int length = 123;
            var arrayElementsSum = new ArrayElementsSum<string>(
                new StringCalculator());
            string res1 = string.Empty;
            string res2 = string.Empty;
            string res3 = string.Empty;
            Random rnd = new Random();

            string[] a = new string[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17).ToString();
            try
            {
                res1 = arrayElementsSum.PlainSumArray(a);
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            try
            {
                res2 = arrayElementsSum.LinqSumArray(a);
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            try
            {
                res3 = arrayElementsSum.ParallerSum(a);
            }
            catch (Exception ex)
            {
                res3 = ex.Message;
            }
            Assert.True(res1 == res2 && res3==res2);
        }
        /// <summary>
        /// Testing Sequential Addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayStringSumTestData.PlainSumArrayTestData), MemberType = typeof(ArrayStringSumTestData))]
        public void PlainSumArrayTestCorrect(string InCode, string InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing linq addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayStringSumTestData.LinqSumArrayTestData), MemberType = typeof(ArrayStringSumTestData))]
        public void LinqSumArrayTestCorrect(string InCode, string InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing ParallerSum with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayStringSumTestData.ParallerSumTestData), MemberType = typeof(ArrayStringSumTestData))]
        public void ParallerSumCorrect(string InCode, string InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing Sequential Addition with overflow
        /// </summary>
        [Fact]
        public void PlainSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<string>(new StringCalculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.PlainSumArray(new string[2] { null, "sad" });
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
            var arrayElementsSum = new ArrayElementsSum<string>(new StringCalculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.LinqSumArray(new string[2] { "vv", null });
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Value cannot be null. (Parameter 'b')");
        }
        /// <summary>
        /// Testing ParallerSum with overflow
        /// </summary>
        [Fact]
        public void ParallerSumTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<string>(new StringCalculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.ParallerSum(new string[2] { "vv", null });
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Value cannot be null. (Parameter 'b')");
        }
    }
}
