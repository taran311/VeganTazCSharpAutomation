using System.Collections.Generic;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace VeganTazCSAutomation.PageObjects
{
    public class ExercisePage : BasePage
    {
        public ExercisePage(IWebDriver _driver) : base(_driver)
        {

        }

        public IWebElement Exercise => _driver.FindElement(By.CssSelector("input[class='ui-autocomplete-input']"));

        public IList<IWebElement> AutoCompleteList => _driver.FindElements(By.CssSelector("ul li"));

        public void Get()
        {
            _driver.Navigate().GoToUrl("http://vegantaz.com/exercise.html");
        }
    }
}
