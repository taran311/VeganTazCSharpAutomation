using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using VeganTazCSAutomation.PageObjects;
using VeganTazCSAutomation.Steps;

namespace VeganTazCSharpAutomation.Steps
{
    public class ExerciseSteps: Hooks
    {
        ExercisePage exercisePage = new ExercisePage(driver);

        [When(@"I enter '(.*)' in the Exercise field")]
        public void WhenIEnterInTheExerciseField(string searchString)
        {
            exercisePage.Exercise.SendKeys(searchString);
        }

        [When(@"I click '(.*)' Search Suggestion")]
        public void WhenIClickSearchSuggestion(string searchSuggestion)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(x => exercisePage.AutoCompleteWidget.GetCssValue("display") == "block");
            wait.Until(x => exercisePage.AutoCompleteList.Count() == 1);
            Assert.That(exercisePage.AutoCompleteList.First().Text == searchSuggestion,
                $"{searchSuggestion} search suggestion was not displayed");
            exercisePage.AutoCompleteList.First().Click();
        }

        [Then(@"the '(.*)' video is displayed alongside text '(.*)'")]
        public void ThenTheVideoIsDisplayedContainingText(string searchString, string containsText)
        {
            BasePage basePage = new BasePage(driver);

            var divToGet = searchString.Replace(" ", "");
            var videoSection = basePage.GetDiv(divToGet);
            Assert.That(videoSection.Displayed == true, "Div section was not displayed correctly");
            Assert.That(videoSection.FindElement(By.CssSelector("video")).Displayed == true, "Video was not displayed correctly");
            Assert.That(videoSection.Text.Contains(containsText), "Text Alongside video was not displayed correctly");
        }

        [Then(@"the '(.*)' Search Suggestions are displayed")]
        public void ThenTheSearchSuggestionsAreDisplayed(List<string> searchSuggestions)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(x => exercisePage.AutoCompleteWidget.GetCssValue("display") == "block");
            wait.Until(x => exercisePage.AutoCompleteList.Count() == searchSuggestions.Count);

            CollectionAssert.AreEqual(searchSuggestions, exercisePage.AutoCompleteList.Select(x => x.Text).ToList());
        }


    }
}
