using ArraySumLibrary;

namespace ArraySumConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //логирование
            SLogger sLogger = new SLogger();

            ArraySumTest arraySumTest = new ArraySumTest();
            arraySumTest.TestSpeed(1235678910);
        }
    }
}