using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesSE;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStaffToString()
        {
            Staff s = new Staff();
            s.Id = 123;
            s.IsGP = "yes";
            s.firstName = "David";
            s.lastName = "Penguin";

            string expectedResult = "Dr. David";
            string actualResult = s.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
