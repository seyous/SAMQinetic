using FluentAssertions;
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
        public void ThenTheRibbonHasA(string ribbonName, string visibility)
        {
            _ribbon.IsRibbonButtonEnabled(ribbonName, visibility).Should().BeTrue("The object "+ ribbonName +" is not "+visibility);
        }
    }
}
