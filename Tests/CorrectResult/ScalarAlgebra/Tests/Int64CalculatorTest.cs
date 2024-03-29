﻿using ArraySumLibrary.ScalarAlgebra.Base;
using Tests.CorrectResult.ScalarAlgebra.TestsData;

namespace Tests.CorrectResult.ScalarAlgebra.Tests
{
    public class Int64CalculatorTest
    {
        /// <summary>
        /// Testing getting zero
        /// </summary>
        [Fact]
        public void ZeroTest()
        {
            Assert.True(new Int64Calculator().Zero == 0);
        }

        /// <summary>
        /// Testing adding with Correct Examples
        /// </summary>
        /// <param name="InCode">programmatically</param>
        /// <param name="InReal">expected</param>
        [Theory]
        [MemberData(nameof(Int64CalculatorTestData.AddTestDataCorrect), MemberType = typeof(Int64CalculatorTestData))]
        public void AddTestCorrect(long InCode, long InReal)
        {
            Assert.Equal(InReal, InCode);
        }

        /// <summary>
        /// Testing adding with overflow
        /// </summary>
        [Fact]
        public void AddTestException()
        {
            Int64Calculator int64Calculator = new Int64Calculator();
            string res1 = string.Empty;
            try
            {
                res1 = int64Calculator.Add(long.MaxValue, 11).ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            string res2 = string.Empty;
            try
            {
                res2 = int64Calculator.Add(long.MinValue, -11).ToString();
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            Assert.True(
                        res1 == "Arithmetic operation resulted in an overflow." &&
                        res2 == "Arithmetic operation resulted in an overflow.");
        }

    }

}
