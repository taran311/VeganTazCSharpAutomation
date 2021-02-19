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
    public class FatlossSteps : Hooks
    {
        FatlossPage fatlossPage = new FatlossPage(driver);

        [Then(@"I see an Alert with text '(.*)'")]
        public void GivenIAmOnThePage(string alertMessage)
        {
            Assert.That(fatlossPage.Alert.Text.Contains(alertMessage),
                $"expected Alert Message '{fatlossPage.Alert.Text}' to contain text '{alertMessage}'. But it didn't.");
        }
    }
}
