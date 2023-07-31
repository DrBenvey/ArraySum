using ArraySumLibrary.ScalarAlgebra.Base;

namespace Tests.CorrectResult.ScalarAlgebra.TestsData
{
    public class Int64CalculatorTestData
    {
        private static readonly Int64Calculator int64Calculator = new Int64Calculator();
        /// <summary>
        /// data for testing addition
        /// </summary>
        public static IEnumerable<object[]> AddTestDataCorrect =>
            new List<object[]>
            {
                new object[]
                {
                    int64Calculator.Add(-5,15),
                    10
                },
                new object[]
                {
                    int64Calculator.Add(1,15),
                    16
                }
            };
    }
}
