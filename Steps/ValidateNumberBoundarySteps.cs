using FluentAssertions;
using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class ValidateNumberBoundarySteps
    {

        private readonly RibbonValueObjects _ribbonvalue;


        public ValidateNumberBoundarySteps(RibbonValueObjects ribbonvalue)
        {
            _ribbonvalue = ribbonvalue;
        }

       

        [Then(@"the user click the Settings Tab")]
        public void ThenTheUserClickTheSettingsTab()
        {
            _ribbonvalue.ClickSettingsTab();
        }


        [Then(@"the user enters (.*) into the textbox")]
        public void ThenTheUserEntersIntoTheTextButton(int objectvalue)
        {
            _ribbonvalue.EnterNumberValue(objectvalue.ToString());
        }
      


        [Then(@"the user press the enter key on the keyboard")]
        public void ThenTheUserPressTheEnterKeyOnTheKeyboard()
        {
            _ribbonvalue.PressEnterKey();
        }


        [Then(@"the number changes to (.*) in the textbox")]
        public void ThenTheNumberChangesToInTheTextButton(string valueText)
        {
            _ribbonvalue.GetValueObject(valueText).Should().BeTrue("The value " + valueText + " is not enterered");
                }





    }
}
