using ArraySumLibrary.CarrierAlgebra;
using ArraySumLibrary.ScalarAlgebra;
using Common;
using Serilog;
using System;

SLogger sLogger = new SLogger();
try
{
    
}
catch (Exception ex)
{
    Log.Fatal(ex, ex.Message);
}
finally
{
    Log.CloseAndFlush();
}