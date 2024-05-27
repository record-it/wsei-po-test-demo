using Microsoft.VisualStudio.TestPlatform.TestHost;
using PoTestDemo;
using Xunit.Abstractions;

namespace PoTestDemoTest;

[TestCaseOrderer(
    "PoTestDemoTest.TestOrderer", 
    "PoTestDemoTest")]
public class PoTestDemoTest
{
    private readonly ITestOutputHelper _output;
    private static decimal _points = 0;
    private static decimal _total = 10;

    public PoTestDemoTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestTask01()
    {
        //Arrange
        var d1 = "1";
        var d2 = "2";
        
        //Act
        var result = Task01.AddTwoStringAsDouble("1.1", "2.1");
        
        //Assert
        if (Math.Abs(result - 3.2) < double.Epsilon * 2)
        {
            Assert.True(true);
            CountPoints(1, "Task 1");
        } else
        {
            Assert.True(false);
        }
    }

    [Fact]
    public void TestTask02()
    {
        //Arrange
        
        //Act
        
        //Assert
        Assert.Fail();
        CountPoints(1,"Test");
    }
    
    [Fact]
    public void TaskSummary()
    {
        Assert.Equal(_points, _points);
        _output.WriteLine($"nStudent: {Program.Student}\nPoints: {_points}\nPercent: {_points / _total:P}");
        _output.WriteLine("Points per task");
    }

    private void CountPoints(decimal delta, string testName)
    {
        _points += delta;
        _output.WriteLine($"Points: {_points:F}");
    }
}