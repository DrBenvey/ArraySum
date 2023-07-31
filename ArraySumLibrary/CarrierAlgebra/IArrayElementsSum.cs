using System.Runtime.CompilerServices;

namespace ArraySumLibrary.CarrierAlgebra
{
    /// <summary>
    /// generic interface describing various implementations
    /// element addition operations
    /// https://habr.com/ru/articles/435840/
    /// </summary>
    public interface IArrayElementsSum<T>
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
    }
}
