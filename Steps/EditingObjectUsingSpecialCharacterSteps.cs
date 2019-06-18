using FluentAssertions;
using OpenQA.Selenium.Appium.Windows;
using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM.Steps
{

     [Binding]
    public class EditingObjectUsingSpecialCharacterSteps
    {
        private readonly InsertFormObject _inserformobject;

        public EditingObjectUsingSpecialCharacterSteps(InsertFormObject insertFormObject)
        {
            _inserformobject = insertFormObject;
        }

        [Then(@"the ""(.*)"" should appear on the button")]
        public void ThenTheShouldAppearOnTheButton(string errorMessage)
        {
            _inserformobject.IserrorMessage(errorMessage).Should().BeTrue("Message is not displayed");
        }
    }
}
