namespace ArraySumLibrary.ScalarAlgebra.Base
{
    /// <summary>
    /// Calculator implementation for Int64
    /// </summary>
    public class Int64Calculator : Calculator<long>
    {
        public override long Zero => 0;
        public override bool IsAdditionAssociative => true;

        public override long Add(long a, long b)
        {
            // overflow check (OverflowException)
            checked
            {
                return a + b;
            }
        }
    }
}
