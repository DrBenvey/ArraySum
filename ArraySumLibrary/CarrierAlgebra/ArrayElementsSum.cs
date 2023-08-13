using ArraySumLibrary.ScalarAlgebra;

namespace ArraySumLibrary.CarrierAlgebra
{
    public class ArrayElementsSum<T> : IArrayElementsSum<T>
    {
        private readonly Calculator<T> _calculator;
        public ArrayElementsSum(Calculator<T> calculator)
        {
            if (calculator.IsAdditionAssociative)
                _calculator = calculator;
            else
                throw new ArgumentException("Addition must be associative");
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

        public T ParallerSum(IEnumerable<T> input)
        {
            T[] input_arr=input.ToArray();
            T result = _calculator.Zero;
            int N = 16;
            int M = input.Count() / N;
            T[] partialSums = new T[N];
            for (int i = 0;i< N; i++)
                partialSums[i]= _calculator.Zero;
            
            Parallel.For(0, N, (counter) =>
            {
                T sum = _calculator.Zero;
                for (int i = counter * M; i < (counter + 1) * M; i++)
                    sum = _calculator.Add(sum, input_arr[i]);
                partialSums[counter] = sum;
            });

            for(int i=0;i<N;i++)
                result = _calculator.Add(result, partialSums[i]);

            for (int i = N * M; i < input.Count(); i++)
                result = _calculator.Add(result, input_arr[i]);

            return result;
        }
    }
}
