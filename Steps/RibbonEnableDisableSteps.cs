using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class RibbonEnableDisableSteps
    {
        private readonly RibbonObjects _ribbon;

        public RibbonEnableDisableSteps(RibbonObjects ribbon)
        {
            _ribbon = ribbon;
        }


        [Then(@"the ribbon ""(.*)"" has a ""(.*)""")]
        public void ThenTheRibbonHasA(string ribbonObject, string visible)
        {
            _ribbon.IsRibbonButtonEnabled(ribbonObject, visible);
        }
    }
}
