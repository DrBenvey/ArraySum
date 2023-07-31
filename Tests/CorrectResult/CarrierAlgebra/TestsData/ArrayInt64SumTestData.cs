using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;

namespace Tests.CorrectResult.CarrierAlgebra.TestsData
{
    public class ArrayInt64SumTestData
    {
        private static readonly ArrayElementsSum<long> arrayElementsSum =
            new ArrayElementsSum<long>(new Int64Calculator());

        private static readonly Dictionary<Int64, List<long>> keyValuePairs =
            new Dictionary<Int64, List<long>>
            {
                { 10, new List<long>{1,2,3,4}},
                { 15, new List<long>{1,2,3,4,5}},
                { 0, new List<long>{-1,1}},
                { 25, new List<long>{1,2,3,4,5,-9,19}}
            };

        /// <summary>
        /// data for testing PlainSumArray
        /// </summary>
        public static IEnumerable<object[]> PlainSumArrayTestData =>

            new List<object[]>
            {
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[10]),
                    10
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[15]),
                    15
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[0]),
                    0
                },
                new object[]
                {
                    arrayElementsSum.PlainSumArray(keyValuePairs[25]),
                    25
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
                    arrayElementsSum.LinqSumArray(keyValuePairs[10]),
                    10
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs[15]),
                    15
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs[0]),
                    0
                },
                new object[]
                {
                    arrayElementsSum.LinqSumArray(keyValuePairs[25]),
                    25
                }
            };
    }
}
