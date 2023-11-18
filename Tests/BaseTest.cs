using Aquality.Selenium.Browsers;
using NUnit.Framework;
using UserInterfaceMatskevichM.PageObjects;
using UserInterfaceMatskevichM.PageObjects.Cards;
using UserInterfaceMatskevichM.Utilities.FileUtilities;


namespace UserInterfaceMatskevichM.Tests
{
    public abstract class BaseTest
    {
        private protected StartPage StartPage => _startPage ??= new();
        private protected RegistrationCardForm RegistrationCardForm => _registrationCardForm ??= new();
        private protected RegistrationPage RegistrationPage => _registrationPage ??= new();

        private StartPage _startPage;
        private RegistrationCardForm _registrationCardForm;
        private RegistrationPage _registrationPage;


         [SetUp]
        public void Setup()
        {
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.GoTo(Config.startPageLink);
            AqualityServices.Browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}