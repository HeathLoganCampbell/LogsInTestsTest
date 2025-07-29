namespace LoggingInTestsTest.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Program.Main();
        Assert.Pass();
    }
}