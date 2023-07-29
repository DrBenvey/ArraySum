using ArraySumLibrary.ScalarAlgebra;

namespace Tests.TestData
{
    public class Int64CalculatorTestData
    {
        /// <summary>
        /// data for testing addition
        /// </summary>
        public static IEnumerable<object[]> AddTestDataCorrect =>
            new List<object[]>
            {
                new object[]
                {
                    new Int64Calculator().Add(-5,15),
                    10
                },
                new object[]
                {
                    new Int64Calculator().Add(1,15),
                    16
                }
            };        
    }
}
