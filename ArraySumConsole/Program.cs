using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;
using Common;
using Serilog;

SLogger sLogger = new SLogger();
try
{
    WorkerCalendar some = null;
    WorkerCalendarCalculator workerCalendarCalculator = new WorkerCalendarCalculator();
    string res1 = string.Empty;
    try
    {
        res1 = workerCalendarCalculator.
            Add(
                new WorkerCalendar(
                    "1",
                    new TimeSpan(1, 1, 1),
                    new TimeSpan(1, 1, 1),
                    11),
                new WorkerCalendar(
                    "1",
                    new TimeSpan(1, 1, 1),
                    new TimeSpan(1, 1, 1),
                    Int64.MaxValue)
            ).ToString();
    }
    catch (Exception ex)
    {
        res1 = ex.Message;
    }
    Console.WriteLine(res1);

}
catch (Exception ex)
{
    Log.Fatal(ex, ex.Message);
}
finally
{
    Log.CloseAndFlush();
}