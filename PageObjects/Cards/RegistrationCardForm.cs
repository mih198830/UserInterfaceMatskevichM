﻿using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserInterfaceMatskevichM.Utilities.FileUtilities;

namespace UserInterfaceMatskevichM.PageObjects.Cards
{
    public class RegistrationCardForm : Form
    {
        private static ITextBox pageNumber = ElementFactory.GetTextBox(By.XPath("//div[contains(@class, 'page-indicator')]"), "Page Number");

        protected RegistrationCardForm(By locator, string name) : base(locator, name)
        {
        }



        public int GetPageNumber()
        {
            string pageIndicator = pageNumber.GetText();
            string pageIndicatorNumber = pageIndicator.Split(TestData.PageIndicator)[0].Trim();
            return Convert.ToInt32(pageIndicatorNumber);
        }
    }
}
