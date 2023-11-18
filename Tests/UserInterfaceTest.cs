using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceMatskevichM.Utilities;

namespace UserInterfaceMatskevichM.Tests
{
    public class UserInterfaceTest : BaseTest
    {
        [Test]
        public void RegistrationTest()
        {
            StartPage.nextPageLinkClick();
            int ActualPageNumber = RegistrationCardForm.GetPageNumber();
            Assert.That(ActualPageNumber, Is.EqualTo(1), $"Page number is not {ActualPageNumber}");

            string randomEmail = RandomData.GenerateRandomEmail();

        }
    }
}
