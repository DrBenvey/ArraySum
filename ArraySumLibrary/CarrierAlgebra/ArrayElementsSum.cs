using ArraySumLibrary.ScalarAlgebra;

namespace ArraySumLibrary.CarrierAlgebra
{
    public class ArrayElementsSum<T> : IArrayElementsSum<T>
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
    }
}
