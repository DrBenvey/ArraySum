using ArraySumLibrary.ScalarAlgebra.Base;

namespace ArraySumLibrary.ScalarAlgebra.Custom.Calendar
{
    public class WorkerCalendarCalculator : Calculator<WorkerCalendar>
    {
        private readonly string Header = "Total";
        private readonly Int64Calculator int64Calculator=new Int64Calculator();
        public override WorkerCalendar Zero => new WorkerCalendar(
            TimeSpan.Zero,
            TimeSpan.Zero,
            int64Calculator.Zero,
            Header);

        public override WorkerCalendar Add(WorkerCalendar a, WorkerCalendar b)
        {
            // null check (ArgumentNullException("param"))
            if (a == null)
                throw new ArgumentNullException(nameof(a));
            if (b == null)
                throw new ArgumentNullException(nameof(b));
            return new WorkerCalendar(
                a.ProductiveTime+b.ProductiveTime, 
                a.Distractions + b.Distractions,
                int64Calculator.Add(a.Cost,b.Cost),
                Header);
        }
    }
}
