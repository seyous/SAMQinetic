using FluentAssertions;
using SAM.Utilities;
using SAM.WinFormObjects;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class OpenSAMSteps
    {
        private readonly WarningDialogObjects _warningDialog;

        public OpenSAMSteps(WarningDialogObjects warningDialog)
        {
            _warningDialog = warningDialog;
        }


        [Given(@"a user opens SAM")]
        public void GivenAUserOpensSAM()
        {
            WinDriver.OpenDriver();



        }


    }
}
