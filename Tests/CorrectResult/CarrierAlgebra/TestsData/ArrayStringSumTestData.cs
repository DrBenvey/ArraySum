using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;

namespace Tests.CorrectResult.CarrierAlgebra.TestsData
{
    public class ArrayStringSumTestData
    {
        private static readonly ArrayElementsSum<string> arrayElementsSum =
            new ArrayElementsSum<string>(new StringCalculator());

        private static readonly Dictionary<string, List<string>> keyValuePairs =
            new Dictionary<string, List<string>>
            {
                { "1234", new List<string>{"12","34"}},
                { "qwerty", new List<string>{"q","w","e","r","t","y"}},
                { "12a", new List<string>{"1","2","a"}},
                { "", new List<string>{"",""}}
            };

        /// <summary>
        /// data for testing PlainSumArray
        /// </summary>
        public static IEnumerable<object[]> PlainSumArrayTestData =>

            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs["1234"]),
                    "1234"
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs["qwerty"]),
                    "qwerty"
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs["12a"]),
                    "12a"
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[""]),
                    ""
                }
            };
        /// <summary>
        /// data for testing LinqSumArray
        /// </summary>
        public static IEnumerable<object[]> LinqSumArrayTestData =>
            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs["1234"]),
                    "1234"
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs["qwerty"]),
                    "qwerty"
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs["12a"]),
                    "12a"
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs[""]),
                    ""
                }
            };
        /// <summary>
        /// data for testing ParallerSum
        /// </summary>
        public static IEnumerable<object[]> ParallerSumTestData =>
            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.ParallerSum(keyValuePairs["1234"]),
                    "1234"
                },
                new object[]
                {
                    arrayElementsSum.ParallerSum(keyValuePairs["qwerty"]),
                    "qwerty"
                },
                new object[]
                {
                    arrayElementsSum.ParallerSum(keyValuePairs["12a"]),
                    "12a"
                },
                new object[]
                {
                    arrayElementsSum.ParallerSum(keyValuePairs[""]),
                    ""
                }
            };
    }
}
