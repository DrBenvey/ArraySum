namespace ArraySumLibrary.ScalarAlgebra.Base
{
    public class StringCalculator : Calculator<string>
    {
        public override string Zero => string.Empty;

        public override string Add(string a, string b)
        {
            // null check (ArgumentNullException("param"))
            if (a == null)
                throw new ArgumentNullException(nameof(a));
            if (b == null)
                throw new ArgumentNullException(nameof(b));
            return a + b;
        }
    }
}
