using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VeganTazCSAutomation.PageObjects;

namespace VeganTazCSAutomation.Steps
{
    [Binding]
    public class HomeSteps : Hooks
    {
        HomePage homePage = new HomePage(driver);

        [Given(@"I am on the (.*) Page")]
        public void GivenIAmOnThePage(string page)
        {
            switch (page.ToLower())
            {
                case "home":
                    homePage.Get();
                    break;
                case "fatloss":
                    new FatlossPage(driver).Get();
                    break;
                case "exercise":
                    new ExercisePage(driver).Get();
                    break;
                case "diet":
                    new DietPage(driver).Get();
                    break;
                case "training":
                    new TrainingPage(driver).Get();
                    break;
            }
        }

        [When(@"I click on the (.*) Nav Menu Item")]
        public void WhenIClickOnTheFatlossNavMenuItem(string menuItem)
        {
            BasePage basePage = new BasePage(driver);

            switch (menuItem.ToLower())
            {
                case "home":
                    basePage.Home.Click();
                    break;
                case "fatloss":
                    basePage.Fatloss.Click();
                    break;
                case "exercise":
                    basePage.Exercise.Click();
                    break;
                case "diet":
                    basePage.Diet.Click();
                    break;
                case "training":
                    basePage.Training.Click();
                    break;
            }
        }

        [When(@"I click Learn more button under the (.*) heading")]
        public void WhenIClickLearnMoreButtonUnderTheNaturalBodybuildingWorkoutHeading(string headerString)
        {
            homePage.SelectedHeaderString = headerString;
            homePage.LearnMore.Click();
        }


        [Then(@"I am on the (.*) Page")]
        public void ThenIAmOnThePage(string menuItem)
        {
            var formattedString = menuItem.ToLower().Replace("home","index");
            Assert.That(driver.Url.Contains(formattedString), $"The Url didn't contain {formattedString}, if necessary assert on Page Elements instead of Url");
        }
    }
}
