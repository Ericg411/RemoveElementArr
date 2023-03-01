namespace RemoveElementArr.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = {3, 2, 2, 3};
        int val = 3;
        var result = _test.RemoveElement(nums, val);
        var answer = 2;

        Assert.AreEqual(answer, result);
    }
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        var result = _test.RemoveElement(nums, val);
        var answer = 5;

        Assert.AreEqual(answer, result);
    }
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 6, 4, 3, 2, 2, 2, 2, 2, 2, 2, 1, 5, 6 };
        int val = 2;
        var result = _test.RemoveElement(nums, val);
        var answer = 6;

        Assert.AreEqual(answer, result);
    }
}