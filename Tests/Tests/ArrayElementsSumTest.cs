using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra;
using Tests.TestsData;

namespace Tests.Tests
{
    public class ArrayElementsSumTest
    {
        /// <summary>
        /// Global General Equality Test
        /// </summary>
        [Fact]
        public void GlobalArrayElementsSumTest()
        {
            int length = 123;
            var arrayElementsSum = new ArrayElementsSum<Int64>(new Int64Calculator());
            string res1 = string.Empty;
            string res2 = string.Empty;
            string res3 = string.Empty;
            Random rnd = new Random();
            
            Int64[] a = new Int64[length];
            for (int i = 0; i < length; i++)
                a[i] = rnd.Next(-17, 17);
            try
            {
                res1 = arrayElementsSum.VectorSumArray(a)
                        .ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            try
            {
                res2 = arrayElementsSum.PlainSumArray(a)
                        .ToString();
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            try
            {
                res3 = arrayElementsSum.LinqSumArray(a)
                        .ToString();
            }
            catch (Exception ex)
            {
                res3 = ex.Message;
            }
            Assert.True(res1 == res2 && res1==res3);
        }
        /// <summary>
        /// Testing Sequential Addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayElementsSumTestData.PlainSumArrayTestData), MemberType = typeof(ArrayElementsSumTestData))]
        public void PlainSumArrayTestCorrect(Int64 InCode, Int64 InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing linq addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayElementsSumTestData.LinqSumArrayTestData), MemberType = typeof(ArrayElementsSumTestData))]
        public void LinqSumArrayTestCorrect(Int64 InCode, Int64 InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing vactor addition with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(ArrayElementsSumTestData.VectorSumArrayTestData), MemberType = typeof(ArrayElementsSumTestData))]
        public void VectorSumArrayTestCorrect(Int64 InCode, Int64 InReal)
        {
            Assert.Equal(InReal, InCode);
        }
        /// <summary>
        /// Testing Sequential Addition with overflow
        /// </summary>
        [Fact]
        public void PlainSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<Int64>(new Int64Calculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.PlainSumArray(new Int64[2] {-11,Int64.MinValue})
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
            var arrayElementsSum = new ArrayElementsSum<Int64>(new Int64Calculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.LinqSumArray(new Int64[2] {-11,Int64.MinValue})
                        .ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            Assert.True(res1 == "Arithmetic operation resulted in an overflow.");
        }
        /// <summary>
        /// Testing Vector Addition with overflow
        /// </summary>
        [Fact]
        public void VectorSumArrayTestException()
        {
            var arrayElementsSum = new ArrayElementsSum<Int64>(new Int64Calculator());
            string res1 = string.Empty;
            try
            {
                res1 = arrayElementsSum.VectorSumArray(new Int64[2] { -11, Int64.MinValue })
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
