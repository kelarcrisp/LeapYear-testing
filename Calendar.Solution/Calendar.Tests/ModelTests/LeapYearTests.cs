using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
  [TestClass] ////dotnet run

  public class LeapYearTest
  {


  [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      ////arrange
      LeapYear testLeapYear = new LeapYear();/
      ////assert
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }

    [TestMethod]
    public void IsLeapYear_MultiplesOfFourHundred_True()
    {
    LeapYear testLeapYear = new LeapYear();
    Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }


    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }

    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }

  }
}