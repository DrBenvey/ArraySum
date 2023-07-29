using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra;

namespace Tests.TestsData
{
    public class ArrayElementsSumTestData
    {
        /// <summary>
        /// data for testing PlainSumArray
        /// </summary>
        public static IEnumerable<object[]> PlainSumArrayTestData =>
            new List<object[]>
            {
                new object[]
                {
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{1,2,3,4}),
                    10
                },
                new object[]
                {
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{1,2,3,4,5}),
                    15
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
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{1,2,3,4}),
                    10
                },
                new object[]
                {
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{1,2,3,4,5}),
                    15
                }
            };
        /// <summary>
        /// data for testing VectorSum
        /// </summary>
        public static IEnumerable<object[]> VectorSumArrayTestData =>
            new List<object[]>
            {
                new object[]
                {
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{-1,1}),
                    0
                },
                new object[]
                {
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{1,2,3,4,5}),
                    15
                },
                new object[]
                {
                    new ArrayElementsSum<Int64>(new Int64Calculator())
                        .PlainSumArray(new List<Int64>{1,2,3,4,5,-9,19}),
                    25
                }
            };
    }
}
