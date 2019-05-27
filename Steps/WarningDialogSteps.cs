using FluentAssertions;
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

        [When(@"the warning message is displayed")]
        public void WhenTheWarningMessageIsDisplayed()
        {
            _warningDialog.IsWarningDialogDisplayed().Should().BeTrue("The message is not displayed");
        }

        [When(@"the user can click on the OK button")]
        [Then(@"the user can click on the OK button")]
        public void ThenTheUserCanClickOnTheOKButton()
        {
            _warningDialog.OKButtonIsClickedOnWarningDialog();
        }
      
    }
}
