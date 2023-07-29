namespace ArraySumLibrary.ScalarAlgebra
{
    /// <summary>
    /// Calculator implementation for Int64
    /// </summary>
    public class Int64Calculator : Calculator<Int64>
    {
        public override Int64 Zero => 0;
        /// <summary>
        /// adding
        /// </summary>
        /// <param name="a">first</param>
        /// <param name="b">second</param>
        /// <returns>result of summation or OverflowException ex</returns>
        public override Int64 Add(Int64 a, Int64 b)
        {
            checked
            {
                return a + b;
            }        
        }
    }
}
