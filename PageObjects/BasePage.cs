using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class BasePage
    {
        protected static IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Home => _driver.FindElement(By.Id("nav-index"));

        public IWebElement Fatloss => _driver.FindElement(By.Id("nav-fatloss"));

        public IWebElement Exercise => _driver.FindElement(By.Id("nav-exercise"));

        public IWebElement Diet => _driver.FindElement(By.Id("nav-diet"));

        public IWebElement Training => _driver.FindElement(By.Id("nav-training"));

        public IWebElement GetDiv(string divToGet) => _driver.FindElement(By.CssSelector($"#{divToGet}Div"));

        
    }
}
