﻿using FluentAssertions;
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

        [When(@"the user click the layout Tab")]
        [Then(@"the user click the layout Tab")]
        public void ThenTheUserClickTheLayoutTab()
        {
            _ribbon.ClickLayoutTab();
        }

        [When(@"the user click the File Tab")]
        [Then(@"the user click the File Tab")]
        public void ThenTheUserClickTheFileTab()
        {
            _ribbon.ClickFileTab();
        }

        [When(@"the user click the SAM Tab")]
        [Then(@"the user click the SAM Tab")]
        public void ThenTheUserClickTheSAMTab()
        {
            _ribbon.ClickSAMTab();

        }

        [When(@"the user click on the Temp Location Tab")]
        [Then(@"the user click on the Temp Location Tab")]
        public void ThenTheUserClickOnTheTempLocationTab()
        {
            _ribbon.ClickTempLocationTab();
        }


        [When(@"the ribbon ""(.*)"" has a ""(.*)""")]
        [Then(@"the ribbon ""(.*)"" has a ""(.*)""")]
        public void ThenTheRibbonHasA(string ribbonName, string visibility)
        {
            _ribbon.IsRibbonButtonEnabled(ribbonName, visibility).Should().BeTrue("The object "+ ribbonName +" is not "+visibility);
        }
    }
}
