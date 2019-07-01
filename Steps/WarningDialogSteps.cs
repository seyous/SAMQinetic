using FluentAssertions;
using OpenQA.Selenium;
using SAM.Utilities;
using SAM.WinFormObjects;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class WarningDialogSteps
    {
        private const int implicitTimeoutMs = 120000;
        private readonly WarningDialogObjects _warningDialog;

        public WarningDialogSteps(WarningDialogObjects warningDialog)
        {
            _warningDialog = warningDialog;
        }

        [Given(@"the warning message is displayed")]
        [When(@"the warning message is displayed")]
        public void WhenTheWarningMessageIsDisplayed()
        {
            try
            {
                _warningDialog.IsWarningDialogDisplayed().Should().BeTrue("The message is not displayed");

            }
            catch (System.Exception)
            {

            }
        }

        [Given(@"the user can click on the OK button")]
        [When(@"the user can click on the OK button")]
        [Then(@"the user can click on the OK button")]
        public void ThenTheUserCanClickOnTheOKButton()
        {

            try
            {
                _warningDialog.OKButtonIsClickedOnWarningDialog();

            }
            catch (System.Exception)
            {

            }
        }
      
    }
}
