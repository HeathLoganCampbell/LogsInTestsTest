using Microsoft.Extensions.Logging;

namespace LoggingInTestsTest;

public class Class1(ILogger<Class1> logger)
{
    public void Blah()
    {
        logger.LogInformation("I am monkey");
    }
}