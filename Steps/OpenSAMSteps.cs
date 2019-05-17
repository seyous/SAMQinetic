using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using SAM.Helper;
using System;
using System.Threading;
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
            _warningDialog.IsSAMOpened().Should().BeTrue("SAM is not opened");
        }


    }
}
