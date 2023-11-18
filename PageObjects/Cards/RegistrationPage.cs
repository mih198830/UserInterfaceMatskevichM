using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserInterfaceMatskevichM.Utilities;

namespace UserInterfaceMatskevichM.PageObjects.Cards
{
    public class RegistrationPage : Form
    {
        private ITextBox choosePassword = ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder, 'Choose Password')]"), "password field");
        private ITextBox chooseEmail = ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder, 'Your email')]"), "email field");
        private IButton domainDropDownOpener = ElementFactory.GetButton(By.XPath("//input[contains(@class, 'dropdown__opener')]"), "domain drop-down");
        private IList<IButton> dropDownDomainOptions = ElementFactory.FindElements<IButton>(By.XPath("//*[contains(@class,'dropdown__list-item') and not(contains(@class,'selected'))]"), "domainDropdownList", state: ElementState.ExistsInAnyState);


        public RegistrationPage() : base(By.ClassName("login-form"), "UserInterfacePage")
        {
        }

        public void FillPasswordField(string password)
        {
            choosePassword.ClearAndType(password);
        }

        public void FillEmailField(string email)
        {
            chooseEmail.ClearAndType(email);
        }

        public void SelectDomain(string domain)
        {
            domainDropDownOpener.Click();
            dropDownDomainOptions.GetRandomElement().Click();
        }
    }
}
