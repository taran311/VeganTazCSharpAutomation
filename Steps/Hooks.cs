using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.Steps
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;

        [BeforeTestRun]
        public static void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterTestRun]
        public static void AfterTest()
        {
            driver.Quit();
        }
    }
}
