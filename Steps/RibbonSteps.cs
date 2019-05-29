using FluentAssertions;
using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    
    public class OpenInsertDialogSteps
    {
        private readonly RibbonObjects _ribbon;

        public OpenInsertDialogSteps(RibbonObjects ribbon)
        {
            _ribbon = ribbon;
        }

        [Then(@"the only object ""(.*)"" is displayed")]
        public void ThenTheOnlyObjectIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"the user clicks on the Insert button")]
        [Then(@"the user clicks on the Insert button")]
        public void ThenTheUserClicksOnTheInsertButton()
        {
            _ribbon.ClickInsertButton();
        }

        [Then(@"the ribbon ""(.*)"" is displayed")]
        public void ThenTheRibbonIsDisplayed(string ribbonName)
        {
            _ribbon.IsRibbonButtonDisplayed(ribbonName).Should().BeTrue();
        }

    }
}
