using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
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

        [Then(@"the '(.*)' Search Suggestions are displayed")]
        public void ThenTheSearchSuggestionsAreDisplayed(List<string> searchSuggestions)
        {
            var test = searchSuggestions;
            var test2 = exercisePage.AutoCompleteList.;
            CollectionAssert.AreEqual(searchSuggestions, exercisePage.AutoCompleteList);
        }


    }
}
