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

        [Then(@"the user clicks on the Insert button")]
        public void ThenTheUserClicksOnTheInsertButton()
        {
            _ribbon.ClickInsertButton();
        }

    }
}
