using System;
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
            System.Diagnostics.Debug.WriteLine("Initializing ChromeDriver");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();            
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            System.Diagnostics.Debug.WriteLine($"Feature File: {featureContext.FeatureInfo.Title}");
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            System.Diagnostics.Debug.WriteLine($"Scenario: {scenarioContext.ScenarioInfo.Title}");
        }

        [AfterScenario]
        public static void AfterScenario(ScenarioContext scenarioContext)
        {
            if(scenarioContext.TestError != null)
            {
                System.Diagnostics.Debug.WriteLine("Exception, generating screenshot");
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile($"C://VeganTazCSharpAutomation/{scenarioContext.ScenarioInfo.Title}.png", ScreenshotImageFormat.Png);
            }
        }

        [AfterTestRun]
        public static void AfterTest()
        {
            System.Diagnostics.Debug.WriteLine("Terminating ChromeDriver");
            driver.Quit();
        }
    }
}
