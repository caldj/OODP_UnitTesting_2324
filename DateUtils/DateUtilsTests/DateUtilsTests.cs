namespace DateUtilsTests;

[TestClass]
public class DateUtilsTests
{
    [DataTestMethod]
    [DataRow(2024,true)]
    [DataRow(2023,false)]
    [DataRow(2000,true)]
    [DataRow(1900,false)]
    [DataRow(-7263,false)]
    public void TestIsLeap(int year, bool expected)
    {
        bool actual = Utils.IsLeap(year);
        Assert.AreEqual(expected, actual,$"\nYear: {year};  Expected: {expected};  Actual: {actual}");
    }
}