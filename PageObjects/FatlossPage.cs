using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class FatlossPage : BasePage
    {
        public FatlossPage(IWebDriver _driver) : base(_driver)
        {

        }

        public IWebElement Alert => _driver.FindElement(By.CssSelector(".alert"));

        public void Get()
        {
            _driver.Navigate().GoToUrl("http://vegantaz.com/fatloss.html");
        }
    }
}
