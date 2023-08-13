using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra.Base;
using ArraySumLibrary.ScalarAlgebra.Custom.Calendar;
using Common;
using Serilog;

SLogger sLogger = new SLogger();
try
{
    /// Example of using PlainSumArray for Int64
    try
    {
        ArrayElementsSum<long> arrayElementsSumInt64 =
            new ArrayElementsSum<long>(new Int64Calculator());
        Log.Information(arrayElementsSumInt64.PlainSumArray(
            new List<long> { 1, 2, 3, 4 }).ToString());
    }
    catch (Exception ex)
    {
        Log.Error(ex, ex.Message);
    }
    /// Example of using LinqSumArray for string
    try
    {
        ArrayElementsSum<string> arrayElementsSumString =
            new ArrayElementsSum<string>(new StringCalculator());
        Log.Information(arrayElementsSumString.LinqSumArray(
            new List<string> { "Hello", " ","world" }).ToString());
    }
    catch (Exception ex)
    {
        Log.Error(ex, ex.Message);
    }
    /// Example of using LinqSumArray for WorkerCalendar
    try
    {
        ArrayElementsSum<WorkerCalendar> arrayElementsSumWorkerCalendar =
            new ArrayElementsSum<WorkerCalendar>(new WorkerCalendarCalculator());
        Log.Information(arrayElementsSumWorkerCalendar.LinqSumArray(
            new List<WorkerCalendar> { 
                new WorkerCalendar(
                    "1",
                    new TimeSpan(1,1,1),
                    new TimeSpan(1, 1, 1),
                    11),
                new WorkerCalendar(
                    "2",
                    new TimeSpan(1, 1, 1),
                    new TimeSpan(1, 1, 1),
                    22)}).ToString());
    }
    catch (Exception ex)
    {
        Log.Error(ex, ex.Message);
    }
}
catch (Exception ex)
{
    Log.Fatal(ex, ex.Message);
}
finally
{
    Log.CloseAndFlush();
}