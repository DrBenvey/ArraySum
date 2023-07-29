using System.Runtime.CompilerServices;

namespace ArraySumLibrary.CarrierAlgebra
{
    /// <summary>
    /// generic interface describing various implementations
    /// element addition operations
    /// https://habr.com/ru/articles/435840/
    /// </summary>
    public interface IArrayElementsSum<T> where T : struct
    {
        /// <summary>
        /// simple sequential addition
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>result of summation or OverflowException ex</returns>
        T PlainSumArray(IEnumerable<T> input);
        /// <summary>
        /// addition with linq
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>result of summation or OverflowException ex</returns>
        T LinqSumArray(IEnumerable<T> input);
        /// <summary>
        /// addition using vectors
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>result of summation or OverflowException ex</returns>
        T VectorSumArray(IEnumerable<T> input);
        /// <summary>
        /// Async addition
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>result of summation or OverflowException ex</returns>
        Task<T> SumArrayAsync(IEnumerable<T> input);
        /// <summary>
        /// addition using vectors
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>result of summation or OverflowException ex</returns>
        T ThreadSumArray(IEnumerable<T> input);
        /// <summary>
        /// addition with Intrinsics
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>result of summation or OverflowException ex</returns>
        unsafe T IntrinsicsSumArray(IEnumerable<T> input);
    }
}
