using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BankApplication.Savings;

namespace UnitTestBankApplication
{
    [TestClass]
    public class AccountUnitTest
    {
        // Test if an account is active
        [TestMethod][Priority(0)] [TestCategory("Happy Path")]
        public void TestAccountStatus_Active_Success()
        {            
            // Arrange
            Account objAccount = new Account();

            // Act
            bool actualResult = objAccount.IsAccountActive("1234");

            //Assert
            Assert.IsTrue(actualResult, "Failed; Account is not Active");
        }

        // Exception is thrown if Null is passed as an Account Number.
        [TestMethod]
        [Priority(0)]
        [TestCategory("Sad Path")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAccountStatus_ArgumentException_Success()
        {
            // Arrange
            Account objAccount = new Account();

            // Act
            bool actualResult = objAccount.IsAccountActive(null);
        }

        // Exception is thrown if WhiteSpace " " is passed as Account Number.
        [TestMethod]
        [Priority(0)]
        [TestCategory("Sad Path")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAccountStatus_AccountNumberWhiteSpace_ArgumentException_Success()
        {
            // Arrange
            Account objAccount = new Account();

            // Act
            bool actualResult = objAccount.IsAccountActive(" ");
        }
    }
}
