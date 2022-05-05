using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class DietPage : BasePage
    {

        private IList<IWebElement> CardBodies = _driver.FindElements(By.CssSelector("cards-body"));
        public DietPage(IWebDriver _driver) : base(_driver)
        {

        }

        public void Get()
        {
            _driver.Navigate().GoToUrl("http://vegantaz.com/diet.html");
        }
    }
}
