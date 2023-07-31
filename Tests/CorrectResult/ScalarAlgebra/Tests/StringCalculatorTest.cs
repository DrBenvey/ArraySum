using ArraySumLibrary.ScalarAlgebra.Base;
using Tests.CorrectResult.ScalarAlgebra.TestsData;

namespace Tests.CorrectResult.ScalarAlgebra.Tests
{
    public class StringCalculatorTest
    {
        /// <summary>
        /// Testing getting zero
        /// </summary>
        [Fact]
        public void ZeroTest()
        {
            Assert.True(new StringCalculator().Zero == string.Empty);
        }

        /// <summary>
        /// Testing adding with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(StringCalculatorTestData.AddTestDataCorrect), MemberType = typeof(StringCalculatorTestData))]
        public void AddTestCorrect(string InCode, string InReal)
        {
            Assert.Equal(InReal, InCode);
        }

        /// <summary>
        /// Testing adding with overflow
        /// </summary>
        [Fact]
        public void AddTestException()
        {
            StringCalculator stringCalculator = new StringCalculator();
            string res1 = string.Empty;
            try
            {
                res1 = stringCalculator.Add(null, "sssssss").ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            string res2 = string.Empty;
            try
            {
                res2 = stringCalculator.Add("bbbbbb", null).ToString();
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            Assert.True(
                        res1 == "Value cannot be null. (Parameter 'a')" &&
                        res2 == "Value cannot be null. (Parameter 'b')");
        }
    }
}
