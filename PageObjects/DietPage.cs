using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class DietPage : BasePage
    {
        public DietPage(IWebDriver _driver) : base(_driver)
        {

        }

        public void Get()
        {
            _driver.Navigate().GoToUrl("http://vegantaz.com/diet.html");
        }
    }
}
