using Serilog;

namespace ArraySumLibrary
{
    public class SLogger
    {
        public SLogger()
        {
            string path = Path.Combine(
                Directory.GetCurrentDirectory().ToString(),
                "Logs");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string full_path = Path.Combine(path, "log.txt");
            if (File.Exists(full_path))
            {
                File.Delete(full_path);
            }
            Log.Logger = new LoggerConfiguration().
                MinimumLevel.Debug().
                WriteTo.Console().
                WriteTo.File(full_path).
                CreateLogger();
        }

    }
}