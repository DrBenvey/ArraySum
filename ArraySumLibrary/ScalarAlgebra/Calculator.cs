namespace ArraySumLibrary.ScalarAlgebra
{
    /// <summary>
    /// abstract generic calculator class
    /// describing the necessary operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Calculator<T>
    {
        /// <summary>
        /// zero
        /// </summary>
        public abstract T Zero { get; }
        /// <summary>
        /// addition
        /// </summary>
        /// <param name="a">first</param>
        /// <param name="b">second</param>
        /// <returns>result of summation or Exception ex</returns>
        public abstract T Add(T a, T b);
        /// <summary>
        /// is addition associative
        /// </summary>
        public abstract bool IsAdditionAssociative { get; }
    }
}
