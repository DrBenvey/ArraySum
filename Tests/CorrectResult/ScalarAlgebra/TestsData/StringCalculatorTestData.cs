using ArraySumLibrary.ScalarAlgebra.Base;

namespace Tests.CorrectResult.ScalarAlgebra.TestsData
{
    public class StringCalculatorTestData
    {
        private static readonly StringCalculator stringCalculator = new StringCalculator();
        /// <summary>
        /// data for testing addition
        /// </summary>
        public static IEnumerable<object[]> AddTestDataCorrect =>
            new List<object[]>
            {
                new object[]
                {
                    stringCalculator.Add("a","b"),
                    "ab"
                }
            };
    }
}
