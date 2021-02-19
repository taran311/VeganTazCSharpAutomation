using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public string SelectedHeaderString { get; set; }

        public IWebElement CardHeader => _driver.FindElement(By.XPath($"//div[contains(@class, 'card-header')][contains(text(), '{SelectedHeaderString}')]"));

        public IWebElement LearnMore => CardHeader.FindElement(By.XPath("../div[contains(@class, 'card-body')]/a[text()='Learn more']"));

        public void Get()
        {
            _driver.Navigate().GoToUrl("http://vegantaz.com/index.html");
        }
    }
}
