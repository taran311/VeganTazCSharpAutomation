using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class TrainingPage : BasePage
    {
        public TrainingPage(IWebDriver _driver) : base(_driver)
        {

        }

        public void Get()
        {
            _driver.Navigate().GoToUrl("http://vegantaz.com/training.html");
        }
    }
}
