using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace VeganTazCSharpAutomation.Helpers
{
    [Binding]
    public class StepArgumentTransformations
    {
        [StepArgumentTransformation]
        public List<string> TransformStringIntoList(string stringToParse)
        {
            var formattedString = stringToParse.Replace(" ", "");
            var stringArray = formattedString.Split(',');
            var listOfStrings = stringArray.OfType<string>().ToList();
            return listOfStrings;
        }
    }
}
