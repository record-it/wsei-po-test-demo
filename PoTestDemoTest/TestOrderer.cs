using Xunit.Abstractions;
using Xunit.Sdk;

public class TestOrderer: ITestCaseOrderer
{
    public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase  =>
        testCases.OrderBy(testCase => testCase.TestMethod.Method.Name);
}