using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterfaceMatskevichM.PageObjects
{
    public class StartPage: Form 
    {
        private static IButton hereButton = ElementFactory.GetButton(By.XPath("//div[@id='app']//button[contains(@class,'start__button')]"), "startButton");
        private ILink nextPageLink = ElementFactory.GetLink(By.XPath("//div[@id='app']//a[contains(@class,'start__link')]"), "nextPageLink");
        
        public StartPage() : base(hereButton.Locator, "UserInterfacePage")
        {
        }


        public void nextPageLinkClick()
        {
            nextPageLink.Click();
        }
    }
}
