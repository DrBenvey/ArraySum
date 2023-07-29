using ArraySumLibrary.ScalarAlgebra;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;

namespace ArraySumLibrary.CarrierAlgebra
{
    public class ArrayElementsSum<T> : IArrayElementsSum<T> where T : struct
    {
        private readonly Calculator<T> _calculator;
        public ArrayElementsSum(Calculator<T> calculator)
        {
            _calculator = calculator;
        }

        public T PlainSumArray(IEnumerable<T> input)
        {
            T result = _calculator.Zero;
            foreach (T item in input)
                result = _calculator.Add(result, item);
            return result;
        }

        public T LinqSumArray(IEnumerable<T> input)
        {
            Func<T, T, T> summer = (item1, item2) => _calculator.Add(item1, item2);
            return input.Aggregate<T>(summer);
        }

        public T VectorSumArray(IEnumerable<T> input) 
        {
            int vectorSize = Vector<T>.Count;
            var accVector = Vector<T>.Zero;
            var array = input.ToArray();
            int i;
            for (i = 0; i < array.Length - vectorSize; i += vectorSize)
            {
                var v = new Vector<T>(array, i);
                accVector = Vector.Add(accVector, v);
            }
            T result = Vector.Dot<T>(accVector, Vector<T>.One);
            for (; i < array.Length; i++)
                result = _calculator.Add(result, array[i]);
            return result;
        }

        public unsafe T IntrinsicsSumArray(IEnumerable<T> input)
        {
            throw new NotImplementedException();
        }

        public async Task<T> SumArrayAsync(IEnumerable<T> input)
        {
            throw new NotImplementedException();
        }

        public T ThreadSumArray(IEnumerable<T> input)
        {
            throw new NotImplementedException();
        }
    }
}
