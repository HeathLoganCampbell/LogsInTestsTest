using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace LoggingInTestsTest;
public class Program
{
    public static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .CreateLogger();
        
        var services = new ServiceCollection();

        services.AddLogging(configure => configure.AddConsole());
        services.AddTransient<Class1>();
        
        services.AddLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddSerilog();
        });

        var provider = services.BuildServiceProvider();

        var instance = provider.GetRequiredService<Class1>();
        instance.Blah();
        
        Log.CloseAndFlush();
    }
}