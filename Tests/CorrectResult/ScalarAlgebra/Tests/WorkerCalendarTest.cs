using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;

namespace Tests.CorrectResult.ScalarAlgebra.Tests
{
    public class WorkerCalendarTest
    {
        /// <summary>
        /// Testing ConstructExeption
        /// </summary>
        [Fact]
        public void TestConstructExeption()
        {
            string res1=string.Empty;
            string res2=string.Empty;
            string res3=string.Empty;
            string res4=string.Empty;
            try
            {
                var t1 = new WorkerCalendar(
                                "Sam",
                                new TimeSpan(1, 2, 3),
                                new TimeSpan(1, 3, 4),
                                -11);
                res1 = t1.ToString();
            }
            catch (Exception ex)
            {
                res1 = ex.Message;
            }
            try
            {
                var t2 = new WorkerCalendar(
                            "Tom",
                            new TimeSpan(-7, 7, 7),
                            new TimeSpan(0, 0, 0),
                            115);
                res2 = t2.ToString();
            }
            catch (Exception ex)
            {
                res2 = ex.Message;
            }
            try
            {
                var t3 = new WorkerCalendar(
                            "Denis",
                            new TimeSpan(7, 7, 7),
                            new TimeSpan(-1, 0, 0),
                            115);
                res3 = t3.ToString();
            }
            catch (Exception ex)
            {
                res3 = ex.Message;
            }
            try
            {
                var t4 = new WorkerCalendar(
                            null,
                            new TimeSpan(0, 0, 0),
                            new TimeSpan(1, 1, 1),
                            12);
                res4 = t4.ToString();
            }
            catch (Exception ex)
            {
                res4 = ex.Message;
            }
            Assert.True(
                    res1== "Specified argument was out of the range of valid values. (Parameter 'Cost')" &&
                    res2== "Specified argument was out of the range of valid values. (Parameter 'ProductiveTime')" &&
                    res3== "Specified argument was out of the range of valid values. (Parameter 'Distractions')" &&
                    res4== "Value cannot be null. (Parameter 'Name')");
        }
        
        /// <summary>
        /// Testing toString
        /// </summary>
        [Fact]
        public void TestToString()
        {
            var t1 = new WorkerCalendar(
                "Sam",
                new TimeSpan(1, 2, 3),
                new TimeSpan(1, 3, 4),
                11);
            Assert.True(t1.ToString() == 
                $"===\n{t1.Name}\n---\nProductive: {t1.ProductiveTime}\nDistractions: {t1.Distractions}\nCost: {t1.Cost}\n===");
        }

        /// <summary>
        /// Testing Equals
        /// </summary>
        [Fact]
        public void TestEquals()
        {
            var t1 = new WorkerCalendar(
                "Sam",
                new TimeSpan(1, 2, 3),
                new TimeSpan(1, 3, 4),
                11);
            var t2 = new WorkerCalendar(
                "Sam",
                new TimeSpan(1, 2, 3),
                new TimeSpan(1, 3, 4),
                11);
            Assert.True(t1.Equals(t2));
        }

        /// <summary>
        /// Testing Hash
        /// </summary>
        [Fact]
        public void TestHash()
        {
            var t1 = new WorkerCalendar(
                "Sam",
                new TimeSpan(1, 2, 3),
                new TimeSpan(1, 3, 4),
                11);
            var t2 = new WorkerCalendar(
                "Tom",
                new TimeSpan(1, 2, 3),
                new TimeSpan(1, 3, 4),
                11);
            var dictionary = new Dictionary<WorkerCalendar, WorkerCalendar>() 
            {
                {t1,t2}
            };
            Assert.True(dictionary[t1].Equals(t2));
        }
    }
}
